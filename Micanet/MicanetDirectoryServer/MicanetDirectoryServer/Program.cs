using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace MicanetDirectoryServer
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime ClockInfoFromSystem = DateTime.Now;
            int day1;
            day1 = (int)ClockInfoFromSystem.DayOfWeek;
            currentDay = day1;

            DayOfWeek days = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(ClockInfoFromSystem);
            if (days >= DayOfWeek.Monday && days <= DayOfWeek.Wednesday)
            {
                ClockInfoFromSystem = ClockInfoFromSystem.AddDays(3);
            }
            currentWeek = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(ClockInfoFromSystem, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            Load.LoadAll();
            InitiateStats();
            Console.WriteLine("Micanet Directory Server - Micah Stauffer 2017");
            Console.WriteLine("All time connections: {0}", all);
            Console.WriteLine("Week's connections: {0}", week);
            Console.WriteLine("Day's connections: {0}", day);
            Console.WriteLine("Weekly connections: {0}", weekly);
            Console.WriteLine("Daily connections: {0}", daily);
            Console.WriteLine("Minutely connections: {0}", minutely);
            Connect();
            Console.ReadKey();
        }


        public static int requests = 2;
        public static int counter = 0;
        public static int currentDay;
        public static int currentWeek;

        public static int all = 0;
        public static int week = 0;
        public static int day = 0;
        public static int weekly = 0;
        public static int daily = 0;
        public static int minutely = 0;

        public static List<string> listOfRelays = new List<string>();

        private static void rewrite()
        {
            string dataasstring = "{ \"all\": \"" + all + "\", \"week\": \"" + week + "\", \"day\": \"" + day + "\", \"weekly\": \"" + weekly + "\", \"daily\": \"" + daily + "\", \"minutely\": \"" + minutely + "\"";
            if (counter == 1)
            {
                using (FileStream fs = File.Create(@"C:\Program Files (x86)\Micanet\DirectoryServer\stats.json"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(dataasstring);
                    fs.Write(info, 0, info.Length);

                    // writing data in bytes already
                    byte[] data = new byte[] { 0x0 };
                    fs.Write(data, 0, data.Length);
                }
                counter = 0;
            }
            Console.Clear();
            Console.WriteLine("Micanet Directory Server - Micah Stauffer 2017");
            Console.WriteLine("All time connections: {0}", all);
            Console.WriteLine("Week's connections: {0}", week);
            Console.WriteLine("Day's connections: {0}", day);
            Console.WriteLine("Weekly connections: {0}", weekly);
            Console.WriteLine("Daily connections: {0}", daily);
            Console.WriteLine("Minutely connections: {0}", minutely);
        }

        public static void InitiateStats()
        {
            string statsData = "";
            using (StreamReader sr = File.OpenText(@"C:\Program Files (x86)\Micanet\DirectoryServer\stats.json"))
            {
                string s = "";
                int incrementer = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    if (incrementer == 0)
                    {
                        statsData = s;
                    }
                    else
                    {
                        statsData += s;
                    }
                    incrementer++;
                }
            }

            Match matchesForAllTime = Regex.Match(statsData, "(?<=\"all\": \")((\\w)|| (\\d))[^\"]+");
            all = Int32.Parse(matchesForAllTime.Groups[0].ToString());

            Match matchesForWeek = Regex.Match(statsData, "(?<=\"week\": \")((\\w)|| (\\d))[^\"]+");
            week = Int32.Parse(matchesForWeek.Groups[0].ToString());

            Match matchesForDay = Regex.Match(statsData, "(?<=\"day\": \")((\\w)|| (\\d))[^\"]+");
            day = Int32.Parse(matchesForDay.Groups[0].ToString());

            Match matchesForWeekly = Regex.Match(statsData, "(?<=\"weekly\": \")((\\w)|| (\\d))[^\"]+");
            weekly = Int32.Parse(matchesForWeekly.Groups[0].ToString());

            Match matchesForDaily = Regex.Match(statsData, "(?<=\"daily\": \")((\\w)|| (\\d))[^\"]+");
            daily = Int32.Parse(matchesForDaily.Groups[0].ToString());

            Match matchesForMinutely = Regex.Match(statsData, "(?<=\"minutely\": \")((\\w)|| (\\d))[^\"]+");
            minutely = Int32.Parse(matchesForMinutely.Groups[0].ToString());
        }

        public static int GetIso8601WeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        static void CheckDay()
        {
            DateTime ClockInfoFromSystem = DateTime.Now;
            int day1;
            string day2;
            day1 = (int)ClockInfoFromSystem.DayOfWeek;
            day2 = ClockInfoFromSystem.DayOfWeek.ToString();

            if (currentDay != day1)
            {
                currentDay = day1;
                day = 0;
                day += 1;
            }
            if (currentWeek != GetIso8601WeekOfYear(ClockInfoFromSystem))
            {
                currentWeek = GetIso8601WeekOfYear(ClockInfoFromSystem);
                week = 0;
                week += 1;
                currentDay = day1;
            }
        }

        public static void Connect()
        {
            TcpListener server = null;
            try
            {
                Int32 port = Int32.Parse("56374");
                IPAddress localAddr = IPAddress.Parse("192.168.1.2");

                server = new TcpListener(localAddr, port);

                server.Start();

                Byte[] bytes = new Byte[1024];
                String data = null;

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    data = null;
                    NetworkStream stream = client.GetStream();
                    try
                    {
                        int i;
                        // Loop to receive all the data sent by the client.
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            // Translate data bytes to a ASCII string.
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);

                            Match matchesForRelay = Regex.Match(data, "(?<=\"relays\": \")((\\w)|| (\\d))[^\"]+");
                            listOfRelays = RelayInfo.CreateCircuit(Int32.Parse(matchesForRelay.Groups[0].ToString()));
                            data = "{ ";
                            for (int index = 0; index < listOfRelays.Count; index++)
                            {
                                data += "\"relay" + index + "\": \"" + listOfRelays[index] + "\", ";
                            }
                            data += " }";
                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                            // Send back a response.
                            stream.Write(@msg, 0, msg.Length);
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        data = "404";
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                        stream.Write(@msg, 0, msg.Length);
                    }
                    client.Close();
                    all += 1;
                    counter += 1;
                    week++;
                    day++;
                    CheckDay();
                    rewrite();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
                //ErrorHandler.SocketError(e);
            }
            finally
            {
                server.Stop();
            }
            return;
        }

        private static string getLocalIP()
        {
            try
            {
                string hostNameOrAddress = Dns.GetHostName();
                var hostEntry = Dns.GetHostEntry(hostNameOrAddress);
                foreach (IPAddress ip in hostEntry.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork) //get the first IP V4 address
                        return ip.ToString();
                }
                return "";
            }
            catch (SocketException e)
            {
                //ErrorHandler.SocketError(e);
            }
            return "";
        }
    }
}

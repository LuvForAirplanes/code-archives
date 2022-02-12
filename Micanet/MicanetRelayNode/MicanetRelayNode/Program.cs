using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace MicanetRelayNode
{
    class Program
    {
        public static void Main(string[] args)
        {
            Load.LoadRelays();
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
            ReadStatsFromFile();
            RewriteConsole();
            Connect();
            Console.ReadKey();
        }

        public static string inIP = "192.168.1.2";
        public static string inPort = "5656";
        public static string outPort = "5657";
        public static string outIP = "192.168.1.2";

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

        private static void RewriteSettingsFile()
        {
            string newSettings = "{ \"all\": \"" + all + "\", \"week\": \"" + week + "\", \"day\": \"" + day + "\", \"weekly\": \"" + weekly + "\", \"daily\": \"" + daily + "\", \"minutely\": \"" + minutely + "\"";
            if (counter == 1)
            {
                using (FileStream fs = File.Create(@"C:\Program Files (x86)\Micanet\RelayNode\stats.json"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(newSettings);
                    fs.Write(info, 0, info.Length);
                    byte[] data = new byte[] { 0x0 };
                    fs.Write(data, 0, data.Length);
                }
                counter = 0;
                RewriteConsole();
            }
        }

        public static void RewriteConsole()
        {
            Console.Clear();
            Console.WriteLine("Micanet Relay Node - Micah Stauffer 2017");
            Console.WriteLine("All time connections: {0}", all);
            Console.WriteLine("Week's connections: {0}", week);
            Console.WriteLine("Day's connections: {0}", day);
            Console.WriteLine("Weekly connections: {0}", weekly);
            Console.WriteLine("Daily connections: {0}", daily);
            Console.WriteLine("Minutely connections: {0}", minutely);
        }

        public static void ReadStatsFromFile()
        {
            string statsData = "";
            using (StreamReader sr = File.OpenText(@"C:\Program Files (x86)\Micanet\RelayNode\stats.json"))
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

        private static byte[] ConnectToNextNode(byte[] bytesToProcess)
        {
            byte[] rot = new Byte[1024];
            try
            {
                TcpClient client = new TcpClient(outIP, Convert.ToInt32(outPort));
                Byte[] data = bytesToProcess;
                
                NetworkStream stream = client.GetStream();
                
                stream.Write(data, 0, data.Length);
                
                data = new Byte[1024 * 5000];

                String responseData = String.Empty;
                
                Int32 bytes = stream.Read(data, 0, data.Length);
                stream.Close();
                client.Close();
                return data;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}" + e);
                Console.WriteLine(e.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}" + e);
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
            return rot;
        }

        public static void Connect()
        {
            TcpListener server = null;
            try
            {
                Int32 port = Int32.Parse(inPort);
                IPAddress localAddr = IPAddress.Parse(inIP);
                
                server = new TcpListener(localAddr, port);
                
                server.Start();

                Byte[] bytes = new Byte[1024 * 5000];
                String data = null;

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();

                    data = null;
                    
                    NetworkStream stream = client.GetStream();
                    try
                    {
                        int i;
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            byte[] msg = ConnectToNextNode(bytes);

                            string result = System.Text.Encoding.UTF8.GetString(msg);

                            //result = Security.Encryption.Encrypt(result, "pass");

                            //result = Security.Encryption.Decrypt(result, "pass");

                            byte[] toBytes = Encoding.ASCII.GetBytes(result);

                            stream.Write(toBytes, 0, toBytes.Length);
                        } 
                    }
                    catch (FileNotFoundException)
                    {
                        data = "404";
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                        stream.Write(@msg, 0, msg.Length);
                    }
                    catch
                    {

                    }
                    client.Close();
                    all += 1;
                    counter += 1;
                    week++;
                    day++;
                    CheckDay();
                    RewriteSettingsFile();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
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
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                        return ip.ToString();
                }
            }
            catch
            {

            }
            return "";
        }

        private static string GetIp(string data)
        {
            try
            {
                var matchesForInfo = getInfo(data);
                var matchesForIp = Regex.Matches(matchesForInfo[0].ToString(), @"((\d)+\.){3}(\d)+");
                return matchesForIp[0].ToString();
            }
            catch
            {

            }
            return "";
        }

        private static string GetPort(string data)
        {
            try
            {
                var matchesForInfo = getInfo(data);
                var matchForPort = Regex.Matches(matchesForInfo[0].ToString(), "(?<=:)\\d{1,}(?=\")");
                return matchForPort[0].ToString();
            }
            catch
            {

            }
            return "";
        }

        private static MatchCollection getInfo(string data)
        {
            return Regex.Matches(data, "{ {0,1}\"((\\w) ||\\-) + \": {0,1}\"((\\d) +\\.){ 3} (\\d)+:\\d + \" {0,1}}");
        }
    }
}

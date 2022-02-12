using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Micanet_Server
{
    class Program
    {
        public static void Main(string[] args)
        {
            Connect();
            Console.ReadKey();
        }

        public static void Connect()
        {
            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 56372.
                Int32 port = Int32.Parse("56372");
                IPAddress localAddr = IPAddress.Parse(getLocalIP());

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[1024];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();
                    try
                    {
                        int i;
                        // Loop to receive all the data sent by the client.
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            // Translate data bytes to a ASCII string.
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                            //data = DecryptString(data).ToLower();
                            Console.WriteLine("This is for debugging purposes only! Remove data prints before release!!!");
                            var regExpForMethod = "(?<=\"method\": \")[^\"]((\\d)||(\\w)).[^\"]+";
                            Match matchesForMethod = Regex.Match(data, regExpForMethod);
                            string method = matchesForMethod.Groups[0].ToString();
                            Console.WriteLine(method);
                            
                            var regExpForLang = "(?<=\"lang\": \")[^\"]((\\d)||(\\w)).[^\"]+";
                            Match matchesForLang = Regex.Match(data, regExpForLang);
                            string lang = matchesForLang.Groups[0].ToString();
                            Console.WriteLine(lang);

                            var regExpForUrl = "(?<=\"address\": \")[^\"]((\\d)||(\\w)).[^\"]+";
                            Match matchesForUrl = Regex.Match(data, regExpForUrl);
                            string url = matchesForUrl.Groups[0].ToString();
                            Console.WriteLine(url);
                            using (StreamReader sr = File.OpenText(@"C:\micanet\" + url + ".html"))
                            {
                                string s = "";
                                int incrementer = 0;
                                while ((s = sr.ReadLine()) != null)
                                {
                                    if (incrementer == 0)
                                    {
                                        data = s;
                                    }
                                    else
                                    {
                                        data += s;
                                    }
                                    incrementer++;
                                }
                            }
                            //string micah = EncryptString(data);
                            //byte[] msg = System.Text.Encoding.ASCII.GetBytes(micah);
                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                            // Send back a response.
                            stream.Write(@msg, 0, msg.Length);
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        data = "404";
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                        // Send back a response.
                        stream.Write(@msg, 0, msg.Length);
                    }

                    // Shutdown and end connection
                    client.Close();

                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
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
            catch { }
            return "";
        }
    }
}

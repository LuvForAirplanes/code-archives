using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json;
using Pronect.ConnectionServer.DTOs;

namespace Pronect.ConnectionServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pronect Connection Server 1.0.0.0 - © 2018 by Pronect Software");
            while (true)
            {
                ConnectionToHost();
            }
        }

        public static void ConnectionToHost()
        {
            //set server to nothing
            TcpListener server = null;
            //create connection port
            Int32 port = Int32.Parse("56373");
            //create connection ip
            IPAddress localAddr = IPAddress.Parse(getLocalIP());
            //assign the server its job with a TcpListener with our port and ip handed in
            server = new TcpListener(localAddr, port);
            //starts the server
            server.Start();
            //creates an empty megabyte
            Byte[] bytes = new Byte[1024];
            //sets the return data to null
            String data = null;
            //accepts tcp clients
            TcpClient client = server.AcceptTcpClient();
            //sets the return data to null
            data = null;
            //gets the stream of bytes from the network stream
            NetworkStream stream = client.GetStream();
            //try to receive and parse the data
            try
            {
                while(true) {
                    //declare our incrementer
                    int i;
                    using(var memoryStream = new MemoryStream()) {
                        // Loop to receive all the data sent by the client.
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            // Translate data bytes to a ASCII string.
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);

                            memoryStream.Write(bytes, 0, bytes.Length);
                            bytes = new Byte[1024];
                            if (data.EndsWith("<EOF>"))
                                break;
                        }
                        //get the actual data
                        var stringFromBytes = Encoding.ASCII.GetString(memoryStream.ToArray());
                        //trim off the extra data :)
                        stringFromBytes = Regex.Match(stringFromBytes, ".+?(?=<EOF>)").Value;

                        var serial = JsonConvert.DeserializeObject<ConnectionSend>(stringFromBytes);

                        byte[] msg = Encoding.ASCII.GetBytes(stringFromBytes);

                        stream.Write(@msg, 0, msg.Length);
                        stream.Write(Encoding.ASCII.GetBytes("<EOF>"), 0, Encoding.ASCII.GetBytes("<EOF>").Length);
                    }
                }
            }
            //catch any errors
            catch (Exception e)
            {
                //report the errors
                Console.WriteLine(e);
            }
            //close the client
            client.Close();
            //eventually, stop the server
            server.Stop();
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

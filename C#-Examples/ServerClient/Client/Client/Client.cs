using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Client
{
    public static class Client
    {
        private static TcpClient client;
        private static NetworkStream stream;

        public static void Connect()
        {
            try
            {
                client = new TcpClient(GetLocalIP(), 56372);
                stream = client.GetStream();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void Disconnect()
        {
            try
            {
                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                string exe = e.ToString().ToUpper();
                if (exe.IndexOf("set to an instance") != 1)
                {
                  Console.WriteLine(e);
                }
            }
        }

        public static void Write(byte[] commands)
        {
            using(var sw = new StreamWriter(stream))
            {
                sw.Write(commands);
            }
        }
        
        public static async Task WriteAsync(byte[] commands)
        {
            using (var sw = new StreamWriter(stream))
            {
                sw.Write(commands);
            }
        }

        public static byte[] Read()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        public static async Task ReadAsync()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
            }
        }
        
        public static string GetLocalIP()
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
                return "";
            }
            catch { }
            return "";
        }
    }
}

using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Server 
{
  public static class Server 
  {
    public static TcpListener server = null;

            public static TcpClient client = null;

            public static NetworkStream stream = null;

            public static void Start() 
            {
              //assign the server its job with a TcpListener with our port and ip handed in
              server = new TcpListener(IPAddress.Parse(GetLocalIP()), 56372);
              //start the server
              server.Start();
              client = server.AcceptTcpClient();
            stream = client.GetStream();
            //write the IP Address the request is being received from
            Console.WriteLine(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());
            }

            public static void Stop() 
            {
              //stop the server
              server.Stop();
              //close the client
              client.Close();
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
              //obviously doesn't work yet...
            }

            public static void Write(byte[] data)
            {
            using (var sw = new StreamWriter(stream))
            {
                sw.Write(data);
            }
            }

            public static async Task WriteAsync(byte[] data)
            {
              await stream.WriteAsync(data, 0, data.Length);
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
                            {
                                Console.WriteLine(ip.ToString());
                                return ip.ToString();
                            }
                    }
                    return "";
                }
                catch { }
                return "";
            }
  }
}
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Pronect.Services.Implementations
{
    public class NetworkService : INetworkService
    {
        public IPAddress GetLocalIP()
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
                        return ip;
                    }
                }
                return null;
            }
            catch { }
            return null;
        }
    }
}

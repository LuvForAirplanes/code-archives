using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Pronect.DirectoryServer.Server.Services
{
    public static class NetworkServices
    {
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

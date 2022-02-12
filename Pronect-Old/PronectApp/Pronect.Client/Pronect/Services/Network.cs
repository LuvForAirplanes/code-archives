using Pronect.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Pronect.Services
{
    public class Network
    {
        //public List<NetworkMachine> ScanNetwork(string startIp, string endIp)
        //{
        //    List<NetworkMachine> list = new List<NetworkMachine>();
        //    System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
        //    System.Net.NetworkInformation.PingReply rep = p.Send("192.168.1.1");
        //    if (rep.Status == System.Net.NetworkInformation.IPStatus.Success)
        //    {
        //        NetworkMachine networkMachine = new NetworkMachine();
        //        networkMachine.Ip = rep.Address.ToString();
        //        networkMachine.Name = rep.Address.
        //    }
        //    return list;
        //}

        /// <summary>
        /// Gets the IPv4 Address of the local machine.
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIP()
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
        /// <summary>
        /// Gets the IPv6 address of the local machine.
        /// </summary>
        /// <returns></returns>
        public static string GetLocalMACAddress()
        {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                return (from ip in host.AddressList where !IPAddress.IsLoopback(ip) select ip).ToList()[0].ToString();
        }

        public static IPAddress[] ResolveDomainName(string domain)
        {
            return Dns.GetHostAddresses(domain);
        }
    }
}

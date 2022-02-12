using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ChurchDirectory.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls(GetLocalUrls(args))
                .Build();

        private static string[] GetLocalUrls(string[] args)
        {
            if (args != null)
            {
                foreach (var a in args)
                {
                    if (a.ToLower().StartsWith("--listen-url="))
                        return new string[] { a.Split('=')[1] };
                }
            }

            string hostNameOrAddress = Dns.GetHostName();
            var hostEntry = Dns.GetHostEntry(hostNameOrAddress);
            var urls = hostEntry.AddressList.Select(a => $"http://{a.ToString()}:59261")
                .Concat(new string[] { $"http://{hostNameOrAddress}:59261", "http://localhost:59261" })
                .Distinct()
                .ToArray();
            return urls;
        }
    }
}

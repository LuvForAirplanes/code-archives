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

namespace StaufferRestoration.Website
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
            string hostNameOrAddress = Dns.GetHostName();
            var hostEntry = Dns.GetHostEntry(hostNameOrAddress);
            var urls = hostEntry.AddressList.Select(a => $"http://{a.ToString()}")
                .Concat(new string[] { $"http://{hostNameOrAddress}:5000", "http://localhost:5000" })
                .Distinct()
                .ToArray();
            return urls;
        }
    }
}

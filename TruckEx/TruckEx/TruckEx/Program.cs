using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net;

namespace TruckEx
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
            .UseUrls(GetLocalUrls())
                .Build();


        private static string[] GetLocalUrls()
        {
            string hostNameOrAddress = Dns.GetHostName();
            var hostEntry = Dns.GetHostEntry(hostNameOrAddress);
            var urls = hostEntry.AddressList.Select(a => $"http://{a.ToString()}")
                .Concat(new string[] { $"http://{hostNameOrAddress}", "http://localhost" })
                .Distinct()
                .ToArray();
            return urls;
        }
    }
}

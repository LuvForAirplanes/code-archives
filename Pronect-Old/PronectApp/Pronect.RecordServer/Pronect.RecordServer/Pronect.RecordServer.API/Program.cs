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

namespace Pronect.RecordServer.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pronect Connection Record Server/API 1.0.0.0 - © 2018 by Pronect");
            BuildWebHost(args)
                .Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls(GetLocalUrls(args))    
                .Build();

        private static string[] GetLocalUrls(string[] args)
        {
            foreach (var a in args)
            {
                if (a.ToLower().StartsWith("--listen-url="))
                    return new string[] { a.Split('=')[1] };
            }

            string hostNameOrAddress = Dns.GetHostName();
            var hostEntry = Dns.GetHostEntry(hostNameOrAddress);
            var urls = hostEntry.AddressList.Select(a => $"http://{a.ToString()}:304")
                .Concat(new string[] { $"http://{hostNameOrAddress}:304", "http://localhost:304" })
                .Distinct()
                .ToArray();
            return urls;
        }
    }
}

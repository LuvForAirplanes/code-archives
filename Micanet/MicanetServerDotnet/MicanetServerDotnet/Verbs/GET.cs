using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicanetServerDotnet
{
    class GET
    {
        public static string GetExt(string address)
        {
            string res = address.GetLast(4);
            return res;
        }

        public static string Get(string address, string lang)
        {
            string param = "{ \"method\": \"GET\", \"address\": \"" + address + "\", \"ext\": \"" + GetExt(address) + "\"";
            var sb = new StringBuilder();

            var si = new ProcessStartInfo()
            {
                FileName = @"C:\Users\Micah\Documents\Projects\Micanet\Server-GET\Server-GET\bin\Debug\Server-GET.exe",
                Arguments = param,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            var p = new Process();
            p.StartInfo = si;
            p.OutputDataReceived += (sender, args) => sb.AppendLine(args.Data);
            p.ErrorDataReceived += (sender, args) => sb.AppendLine(args.Data);
            p.Start();
            // start our event pumps
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();

            // until we are done
            p.WaitForExit();
            string returnData = sb.ToString();
            return returnData;
        }
    }

    public static class StringExtension
    {
        public static string GetLast(this string source, int tail_length)
        {
            if (tail_length >= source.Length)
                return source;
            return source.Substring(source.Length - tail_length);
        }
    }
}

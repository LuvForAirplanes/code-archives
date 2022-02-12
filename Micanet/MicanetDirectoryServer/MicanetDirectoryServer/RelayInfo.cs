using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace MicanetDirectoryServer
{
    class RelayInfo
    {
        public static string data = "";
        public static List<string> CreateCircuit(int length)
        {
            Random rnd = new Random();
            List<string> info = new List<string>();
            var matchesForPort = Regex.Matches(data, "(?<=\"relay\\d\": \")((\\w)|| (\\d))[^\"]+");
            for (int index = 0; index < length; index++)
            {
                info.Add(matchesForPort[rnd.Next(0, length)].ToString());
            }
            return info;
        }
    }
}

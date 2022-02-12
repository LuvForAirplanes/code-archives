using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace MicanetRelayNode
{
    class Load
    {
        public static void LoadRelays()
        {
            string data = "";
            try
            {
                using (StreamReader sr = File.OpenText(@"C:\Program Files (x86)\Micanet\RelayNode\settings.json"))
                {
                    string s = "";
                    int incrementer = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (incrementer == 0)
                        {
                            data = s;
                        }
                        else
                        {
                            data += s;
                        }
                        incrementer++;
                    }
                }
            }
            catch
            {

            }
            var matchForInIP = Regex.Matches(data, "(?<=(inip\": \"))((\\d)+\\.){3}(\\d)+");
            var matchesForOutIP = Regex.Matches(data, "(?<=(outip\": \"))((\\d)+\\.){3}(\\d)+");
            Program.inIP = matchForInIP[0].ToString();
            Program.outIP = matchesForOutIP[0].ToString();

            var matchesForInPort = Regex.Matches(data, "(?<=(inport\": \"))(\\d)+");
            var matchesForoutPort = Regex.Matches(data, "(?<=(outport\": \"))(\\d)+");
            Program.inPort = matchesForInPort[0].ToString();
            Program.outPort = matchesForoutPort[0].ToString();
        }
    }
}

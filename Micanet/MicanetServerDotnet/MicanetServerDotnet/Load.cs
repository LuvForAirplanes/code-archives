using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace MicanetServerDotnet
{
    class Load
    {
        public static void LoadContacts()
        {
            string data = "";
            try
            {
                using (StreamReader sr = File.OpenText(@"C:\Program Files (x86)\Micanet\ContentServer\settings.json"))
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

                var matchesForAllTime = Regex.Matches(data, "(?<=\"contact(\\d)\": \")((\\w)|| (\\d))[^\"]+");
                foreach (var t in matchesForAllTime)
                {
                    ErrorReporter.contacts.Add(t.ToString());
                }
            }
            catch { data = ""; }
        }

        public static void LoadAll()
        {
            LoadContacts();
        }
    }
}

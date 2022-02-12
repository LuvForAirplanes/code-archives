using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Server_GET
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "";
            foreach(var num in args)
            {
                data += num;
            }
            
            //data = DecryptString(data).ToLower();
            var regExpForMethod = "(?<=method:)[^,]((\\d)||(\\w)).[^,]+";
            Match matchesForMethod = Regex.Match(data, regExpForMethod);
            string method = matchesForMethod.Groups[0].ToString();
            //Console.WriteLine(method);

            var regExpForLang = "(?<=lang:)[^,]((\\d)||(\\w)).[^,]+";
            Match matchesForLang = Regex.Match(data, regExpForLang);
            string lang = matchesForLang.Groups[0].ToString();
            //Console.WriteLine(lang);

            var regExpForUrl = "(?<=address:)[^,]((\\d)||(\\w)).[^,]+";
            Match matchesForUrl = Regex.Match(data, regExpForUrl);
            string url = matchesForUrl.Groups[0].ToString();
            //Console.WriteLine(url);
            try
            {
                using (StreamReader sr = File.OpenText(@"C:\micanet\" + url + ".html"))
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
            catch { data = ""; }
            Console.WriteLine(data);
        }
    }
}

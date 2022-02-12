using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MicanetDirectoryServer
{
    class Load
    {
        public static void LoadAll()
        {
            LoadRelays();
        }

        public static void LoadRelays()
        {
            string data = "";
            try
            {
                using (StreamReader sr = File.OpenText(@"C:\Program Files (x86)\Micanet\DirectoryServer\relays.json"))
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
            RelayInfo.data = data;
        }
    }
}

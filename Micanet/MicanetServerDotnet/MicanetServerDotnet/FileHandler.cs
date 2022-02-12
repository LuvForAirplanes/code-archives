using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MicanetServerDotnet
{
    class FileHandler
    {
        public static void CreateStatsFile()
        {
            string path = @"E:\AppServ\Example.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("The very first line!");
                tw.Close();
            }
            else if (File.Exists(path))
            {
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("The next line!");
                tw.Close();
            }
        }

        public static void CreateSettingsFile()
        {

        }

        public static void CreateLogFile()
        {

        }
    }
}

using Probek.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Probek
{
    public class Backup
    {
        public Backup(string input)
        {
            CheckCommand(input);
        }

        public void CheckCommand(string input)
        {
            var matches = Regex.Matches(input, @"((\w)|(\\|:|\.|-))+");
            if (matches[1].Value == "run")
            {
                try
                {
                    var backupList = new List<string>();
                    if (matches[2].Value == "-i")
                    {
                        var filemanager = new Files();
                        var trackFile = filemanager.OpenFile(@"C:\Probek\Files.txt");
                        var m = Regex.Matches(trackFile, @"((\w)|(\\|:|\.|-))+");
                        for (int i = 0; i < m.Count; i++)
                        {
                            backupList.Add(m[i].Value);
                        }

                        var backupFile = filemanager.OpenFile(@"C:\Probek\BackupLocation.txt");

                        int ii = 0;
                        foreach (var file in backupList)
                        {
                            filemanager.CopyMoveFolder(new DirectoryInfo(backupFile + "Desktop" + ii.ToString()), new DirectoryInfo(file));
                            ii = ii + 1;
                        }
                    }
                    else if (matches[2].Value == "-d")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Valid backup parameter(s) must be specified.");
                    }
                } catch
                {
                    Console.WriteLine("Backup parameters must be specified.");
                }
            }
        }
    }
}

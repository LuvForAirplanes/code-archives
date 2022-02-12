using System;
using System.Text.RegularExpressions;

namespace Probek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probek C 2018 by Pronect Software");

            while(true)
            {
                string input = Console.ReadLine();
                var match = Regex.Match(input, @"\w+");
                if(match.Value == "diff")
                {
                    var diff = new Diff(input);

                } else if(match.Value == "backup")
                {
                    var backup = new Backup(input);
                }
            }
        }
    }
}

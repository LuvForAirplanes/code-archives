using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Probek
{
    public class Diff
    {
        public Diff(string input)
        {
            CheckCommand(input);
        }

        public void CheckCommand(string input)
        {
            var matches = Regex.Matches(input, @"((\w)|(\\|:|\.))+");
            
        }
    }
}

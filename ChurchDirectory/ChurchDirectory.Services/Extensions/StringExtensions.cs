using System;
using System.Collections.Generic;
using System.Text;

namespace ChurchDirectory.Services.Extensions
{
    public static class StringExtensions
    {
        public static bool ContainsAny(this string haystack, params string[] needles)
        {
            foreach (string needle in needles)
            {
                if (haystack.Contains(needle))
                    return true;
            }

            return false;
        }
    }
}

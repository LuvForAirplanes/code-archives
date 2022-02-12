using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Mouse.SetCursorPos(90, 90);
            Mouse.Click();
        }
    }
}

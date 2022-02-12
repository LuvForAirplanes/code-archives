using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeyboardControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyboard = new Keyboard();
            keyboard.Send(Keyboard.ScanCodeShort.KEY_W);
            keyboard.Send(Keyboard.ScanCodeShort.KEY_O);
            keyboard.Send(Keyboard.ScanCodeShort.KEY_R);
            keyboard.Send(Keyboard.ScanCodeShort.KEY_L);
            keyboard.Send(Keyboard.ScanCodeShort.KEY_D);

            Console.ReadLine();
        }
    }
}

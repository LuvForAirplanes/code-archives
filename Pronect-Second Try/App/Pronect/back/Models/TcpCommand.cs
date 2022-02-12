using System;
using System.Collections.Generic;
using System.Text;

namespace Pronect.Models
{
    public class TcpCommand
    {
        public string CommandName { get; set; }

        public List<string> Parameters { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronect.DTOs.StreamData
{
    public class Command
    {
        /// <summary>
        /// The name of the command.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The list of parameters to go with the command.
        /// </summary>
        public List<string> Parameters { get; set; }
    }
}

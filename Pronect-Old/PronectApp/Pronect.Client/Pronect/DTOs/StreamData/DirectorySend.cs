using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronect.DTOs.StreamData
{
    /// <summary>
    /// Data sent to the directory server.
    /// </summary>
    public class DirectorySend
    {
        /// <summary>
        /// A list of commands to be sent to the directory server.
        /// </summary>
        public List<Command> Commands { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronect.DTOs.StreamData
{
    /// <summary>
    /// The data returned from the remote machine.
    /// </summary>
    public class ConnectionReturn
    {
        /// <summary>
        /// The result of the commands sent to the connection server.
        /// </summary>
        public ReturnCommand CommandResults { get; set; }
        /// <summary>
        /// A list of commands for the local device to execute. (These commands do not return a response)
        /// </summary>
        public List<Command> Commands { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronect.DTOs.StreamData
{
    /// <summary>
    /// Data sent to the connection server for managing the local machine.
    /// </summary>
    public class ConnectionSend
    {
        /// <summary>
        /// The commands for the remote machine.
        /// </summary>
        public List<Command> Commands { get; set; }
        /// <summary>
        /// An image of the desktop for the remote machine.
        /// </summary>
        public byte[] Desktop { get; set; }
        /// <summary>
        /// An audio clip of the local computers sound.
        /// </summary>
        public byte[] Audio { get; set; }
        /// <summary>
        /// Commands that the connection server reads and executes.
        /// </summary>
        public List<Command> ServerCommands { get; set; }
    }
}

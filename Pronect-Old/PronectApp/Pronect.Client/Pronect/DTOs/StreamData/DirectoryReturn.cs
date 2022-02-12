using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronect.DTOs.StreamData
{
    /// <summary>
    /// Data returned from the directory server.
    /// </summary>
    public class DirectoryReturn
    {
        /// <summary>
        /// The result of commands sent to the directory server.
        /// </summary>
        public ReturnCommand CommandReturns { get; set; }
    }
}

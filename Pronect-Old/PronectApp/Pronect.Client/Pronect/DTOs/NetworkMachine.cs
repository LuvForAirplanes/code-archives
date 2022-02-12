using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronect.DTOs
{
    public class NetworkMachine
    {
        /// <summary>
        /// The IP of the computer pinged.
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// The name identifying the machine on the network. 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The type of machine it is. e.g Scanner, Computer, Camera
        /// </summary>
        public string Type { get; set; }
    }
}

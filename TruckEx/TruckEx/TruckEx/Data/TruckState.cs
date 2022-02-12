using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruckEx.Services;

namespace TruckEx.Data
{
    public class TruckState
    {
        public DriveDirection Drive { get; set; }   
        public TurnDirection Steering { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TruckEx.Data;
using TruckEx.Services;

namespace TruckEx.Controllers
{
    [Produces("application/json")]
    [Route("api/Drive")]
    public class DriveController : Controller
    {
        private Truck truckService;

        public DriveController(Truck truck)
        {
            truckService = truck;
        }
        // GET: api/Drive
        [HttpGet]
        public TruckState Get()
        {
            return truckService.GetState();
        }

        // GET: api/Drive/command
        [HttpGet("{command}", Name = "Get")]
        public TruckState Get(string command)
        {
            switch (command.ToLower())
            {
                case "stop":
                    truckService.Stop();
                    break;
                case "start":
                case "forward":
                    truckService.Start(DriveDirection.Forward);
                    break;
                case "reverse":
                    truckService.Start(DriveDirection.Reverse);
                    break;
                case "right":
                    truckService.Turn(TurnDirection.Right);
                    break;
                case "left":
                    truckService.Turn(TurnDirection.Left);
                    break;
                case "straight":
                    truckService.Turn(TurnDirection.Straight);
                    break;
                case "frontlights-on":
                    truckService.Lights(LightLocation.Front, LightStatus.On);
                    break;
                case "frontlights-off":
                    truckService.Lights(LightLocation.Front, LightStatus.Off);
                    break;
                case "backlights-on":
                    truckService.Lights(LightLocation.Back, LightStatus.On);
                    break;
                case "backlights-off":
                    truckService.Lights(LightLocation.Back, LightStatus.Off);
                    break;
                default:
                    break;
            }
            return truckService.GetState();
        }
    }
}

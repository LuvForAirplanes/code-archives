using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckEx.Data;
using TruckEx.Services;

namespace TruckEx.Pages
{
    public class IndexModel : PageModel
    {
        private Truck _truck;

        public IndexModel(Truck truck)
        {
            _truck = truck;
        }

        public TruckState TruckState;

        public void OnGet()
        {
            TruckState = _truck.GetState();
        }

        public IActionResult OnPostDrive(string command)
        {
            switch (command?.ToLower())
            {
                case "stop":
                    _truck.Stop();
                    break;
                case "start":
                case "forward":
                    _truck.Turn(TurnDirection.Straight);
                    _truck.Start(DriveDirection.Forward);
                    break;
                case "reverse":
                    _truck.Turn(TurnDirection.Straight);
                    _truck.Start(DriveDirection.Reverse);
                    break;
                case "right":
                    _truck.Turn(TurnDirection.Right);
                    break;
                case "left":
                    _truck.Turn(TurnDirection.Left);
                    break;
                case "straight":
                    _truck.Turn(TurnDirection.Straight);
                    break;
                case "frontlights-on":
                    _truck.Lights(LightLocation.Front, LightStatus.On);
                    break;
                case "frontlights-off":
                    _truck.Lights(LightLocation.Front, LightStatus.Off);
                    break;
                case "backlights-on":
                    _truck.Lights(LightLocation.Back, LightStatus.On);
                    break;
                case "backlights-off":
                    _truck.Lights(LightLocation.Back, LightStatus.Off);
                    break;
                default:
                    break;
            }

            TruckState = _truck.GetState();

            return Page();
        }
    }
}

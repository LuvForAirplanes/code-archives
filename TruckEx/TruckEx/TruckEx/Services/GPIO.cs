using Bifrost.Devices.Gpio;
using Bifrost.Devices.Gpio.Abstractions;
using Bifrost.Devices.Gpio.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TruckEx.Services
{
    public enum Relay
    {
        Forward,
        Reverse,
        Left,
        Right,
        FrontLights,
        BackLights
    }

    public enum Value
    {
        On,
        Off
    }

    public class GPIO
    {
        private static IGpioController gpioController;

        IGpioPin Forward = null;
        IGpioPin Reverse = null;
        IGpioPin Left = null;
        IGpioPin Right = null;
        IGpioPin FrontLights = null;
        IGpioPin BackLights = null;

        //const string Forward = "forward.txt";
        //const string Reverse = "reverse.txt";
        //const string Left = "left.txt";
        //const string Right = "right.txt";
        //const string FrontLights = "front_lights.txt";
        //const string BackLights = "back_lights.txt";
        //const string Folder = @"C:/Temp/GPIO/";

        public void SetValue(Relay relay, Value value)
        {
            if(Forward == null)
            {
                InitializeGpio();
            }

            GpioPinValue gpioValue = GpioPinValue.Low;

            if (value == Value.On)
            {
                gpioValue = GpioPinValue.High;
            } else
            {
                gpioValue = GpioPinValue.Low;
            }

            switch (relay)
            {
                case Relay.Forward:
                    Forward.Write(gpioValue);
                    break;
                case Relay.Reverse:
                    Reverse.Write(gpioValue);
                    break;
                case Relay.Left:
                    Left.Write(gpioValue);
                    break;
                case Relay.Right:
                    Right.Write(gpioValue);
                    break;
                case Relay.BackLights:
                    BackLights.Write(gpioValue);
                    break;
                case Relay.FrontLights:
                    FrontLights.Write(gpioValue);
                    break;
                default:
                    break;
            }
        }

        public void InitializeGpio()
        {
            gpioController = GpioController.Instance;

            Forward = gpioController.OpenPin(2);
            Reverse = gpioController.OpenPin(3);
            Left = gpioController.OpenPin(4);
            Right = gpioController.OpenPin(14);
            FrontLights = gpioController.OpenPin(15);
            BackLights = gpioController.OpenPin(18);

            Forward.SetDriveMode(GpioPinDriveMode.Output);
            Reverse.SetDriveMode(GpioPinDriveMode.Output);
            Left.SetDriveMode(GpioPinDriveMode.Output);
            Right.SetDriveMode(GpioPinDriveMode.Output);
            BackLights.SetDriveMode(GpioPinDriveMode.Output);
            FrontLights.SetDriveMode(GpioPinDriveMode.Output);
        }
    }
}

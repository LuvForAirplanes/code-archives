using Bifrost.Devices.Gpio;
using Bifrost.Devices.Gpio.Abstractions;
using Bifrost.Devices.Gpio.Core;
using System;

namespace TestGpioCore
{
    class Program
    {
        private static IGpioController gpioController;

        static void Main(string[] args)
        {
			try
			{
				var pinNum = Console.ReadLine();

				gpioController = GpioController.Instance;

				var pin = gpioController.OpenPin(int.Parse(pinNum));

				pin.SetDriveMode(GpioPinDriveMode.Output);

				Console.WriteLine("Going on");
				pin.Write(GpioPinValue.High);
				Console.WriteLine("Going off");
				pin.Write(GpioPinValue.Low);
			} catch (Exception ee)
			{
				Console.WriteLine(ee);
			}

			Main(null);
        }
    }
}

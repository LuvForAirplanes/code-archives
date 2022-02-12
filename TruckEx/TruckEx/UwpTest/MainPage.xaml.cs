using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Gpio;
using Windows.UI.Popups;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private const int LED_PIN = 5;
        private GpioPin pin;

        public MainPage()
        {
            this.InitializeComponent();
            InitGPIOAsync();

            Unloaded += MainPage_Unloaded;
        }

        private void MainPage_Unloaded(object sender, RoutedEventArgs e)
        {
            pin.Dispose();
        }

        public async Task InitGPIOAsync()
        {
            var gpio = GpioController.GetDefault();
            if (gpio == null)
            {
                var dialog = new MessageDialog("No GPIO!");
                await dialog.ShowAsync();

                return;
            }

            pin = gpio.OpenPin(LED_PIN);
            
            pin.Write(GpioPinValue.Low);
            pin.SetDriveMode(GpioPinDriveMode.Output);

            var dialog2 = new MessageDialog("GPIO Initialized!");
            await dialog2.ShowAsync();
        }

        private void on_Click(object sender, RoutedEventArgs e)
        {
            pin.Write(GpioPinValue.High);
        }

        private void off_Click(object sender, RoutedEventArgs e)
        {
            pin.Write(GpioPinValue.Low);
        }
    }
}

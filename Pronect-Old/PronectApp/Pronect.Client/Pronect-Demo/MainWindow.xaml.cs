using Pronect;
using System.Windows;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Forms;
using static Pronect.Services.Keyboard;
using System.Windows.Input;
using System.Collections.Generic;

namespace Pronect_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //This code is NOT the Pronect DLL!!! It is only the UI logic.

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //Checks to see if we are logged in
            if(loginButton.Content.ToString() == "Login")
            {
                //Logs in to the Pronect server -- this account may be used for testing
                PronectInstance.Login("dummy-licen-sekey-00000-00000", "dummy");
                //Signin your current device -- see docs on creating a device for development testing: https://github.com/LuvForAirplanes/PronectClient/wiki/Use-Pronect
                PronectInstance.Signin("a1d72c22-d96e-4c37-8a98-87de8f47f4c5");
                //accept incoming connections from other machines
                PronectInstance.AcceptIncomingConnections = true;
                //Set the Login button content to Logout
                loginButton.Content = "Logout";
            } else
            {
                //Signout your current device
                PronectInstance.Signout("a1d72c22-d96e-4c37-8a98-87de8f47f4c5");
                //Logout of the directory server
                PronectInstance.Logout();
                //Set the Login button content to Login
                loginButton.Content = "Login";
            }
        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            //Checks to see if we are connected
            if (connectButton.Content.ToString() == "Connect")
            {
                //if we are, create a new session
                screenViewer1.PronectSession = new PronectSession
                {
                    Id = idField.Text,
                    Password = passwordField.Text
                };
                //Conenct to the conenction server
                screenViewer1.PronectSession.Connect();
                //Set the connect button to Disconnect
                connectButton.Content = "Disconnect";
            }
            else
            {
                //Disconnect from the conenction server
                screenViewer1.PronectSession.Disconnect();
                //Set the disconnect button to disconnect
                connectButton.Content = "Connect";
            }
        }
    }
}

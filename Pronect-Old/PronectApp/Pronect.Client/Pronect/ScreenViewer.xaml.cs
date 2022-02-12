using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Pronect.RemoteMachine;

namespace Pronect
{
    /// <summary>
    /// Interaction logic for ScreenViewer.xaml
    /// </summary>
    public partial class ScreenViewer : UserControl
    {
        /// <summary>
        /// The ID of the session you are currently viewing.
        /// </summary>
        public string ConnectionId;
        /// <summary>
        /// The <see cref="Pronect.PronectSession"/> this <see cref="ScreenViewer"/> is associated with.
        /// </summary>
        public PronectSession PronectSession;

        public ScreenViewer()
        {
            InitializeComponent();
            var sc = new ScreenCapture();
            internalImageBox.Source = sc.CaptureWindowToBitmap(ScreenCapture.User32.GetDesktopWindow());
        }

        private void internalImageBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.A)
            {
                MessageBox.Show(e.Key.ToString());
                //Char keyChar = (Char)System.Text.Encoding.ASCII.GetBytes(e)[0];
                //PronectSession.RemoteMachine.TypeCharacters(e.)
            }
        }

        private void internalImageBox_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var point = e.GetPosition(this.internalImageBox);
            PronectSession.RemoteMachine.ClickMouse(ClickDirection.Left);
        }

        private void internalImageBox_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            var point = e.GetPosition(this.internalImageBox);
            PronectSession.RemoteMachine.ClickMouse(ClickDirection.Right);
        }

        private void internalImageBox_MouseMove(object sender, MouseEventArgs e)
        {
            var point = e.GetPosition(this.internalImageBox);
            //PronectSession.RemoteMachine.MoveMouse(point);
        }
    }
}

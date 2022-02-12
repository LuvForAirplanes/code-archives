using System.Windows.Controls;
using static Pronect.ScreenCaptureServices;

namespace Pronect.Core.Wpf
{
    /// <summary>
    /// Interaction logic for ScreenViewer.xaml
    /// </summary>
    public partial class ScreenViewer : UserControl
    {
        public PronectSession pronectSession = new PronectSession();

        public ScreenViewer()
        {
            InitializeComponent();
        }
    }
}

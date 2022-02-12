using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Clipex
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        IntPtr nextClipboardViewer;

        public Form1()
        {
            InitializeComponent();

            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)this.Handle);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            ChangeClipboardChain(this.Handle, nextClipboardViewer);
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // defined in winuser.h
            const int WM_DRAWCLIPBOARD = 0x308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    DisplayClipboardData();
                    SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == nextClipboardViewer)
                        nextClipboardViewer = m.LParam;
                    else
                        SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        void DisplayClipboardData()
        {
            try
            {
                IDataObject iData = new DataObject();
                iData = Clipboard.GetDataObject();

                if (iData.GetDataPresent(DataFormats.Rtf))
                    ProcessText((string)iData.GetData(DataFormats.Rtf));
                else if (iData.GetDataPresent(DataFormats.Text))
                    ProcessText((string)iData.GetData(DataFormats.Text));
                else
                    MessageBox.Show("[Clipboard data is not RTF or ASCII Text]");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ProcessText(string message)
        {
            if (message.Contains("StackTrace"))
            {
                ExceptionPage.TextBox.Text = message;
                ExceptionPage.Show();
            }
        }

        public ExceptionPage ExceptionPage = new ExceptionPage();

        private void Form1_Load(object sender, EventArgs e)
        {

            ExceptionPage.Hide();
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            Hide();
        }
    }
}

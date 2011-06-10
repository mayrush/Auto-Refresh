using System.Windows.Forms;
using SpicIE;

namespace PageRefresher
{
    public class AutoRefreshTooButton : SpicIE.Controls.ToolbarButton
    {
        private readonly Timer _timer;
        private bool _isTimerStarted;

        public AutoRefreshTooButton()
        {
            Initialise();

            _timer = new Timer();
            _timer.Tick += _timer_Tick;
            _timer.Interval = 7000;
        }

        public override string PluginGuid { get { return "FA6B0C90-4E98-41C2-AE49-F77F62164685"; } }
        public override string PluginProgID { get { return "PageRefresherPlugin.SpicIE.Button"; } }

        private void Initialise()
        {
            ButtonName = "Autorefresh Button";
            ButtonText = "Refresh page automatically";
            MenuText = "Refresh page automatically";
            MenuStatusBar = "Refresh page automatically";
            HotIconPath = "";
            ButtonAppearance = ButtonAppearanceEnum.COMObject;
            ButtomCustomMenu = ButtonCustomEnum.Tools;

            //HotIconPath = Path.Combine(Host.GetActivePath(), "app.ico");
            //IconPath = Path.Combine(Host.GetActivePath(), "app.ico");
            AssociatedCLSIDExtension = ButtonID;

            OnButtonCommand += AutoRefreshButton_OnButtonCommand;
        }

        private void AutoRefreshButton_OnButtonCommand(int value)
        {
            if (_isTimerStarted)
            {
                _timer.Stop();
                _isTimerStarted = false;
                var messageBox = new FadingMessageBox
                                     {
                                         StartPosition = FormStartPosition.CenterScreen,
                                         Message = "Auto page refresh has stopped!"
                                     };
                messageBox.Show();
            }

            else
            {
                _timer.Start();
                _isTimerStarted = true;

                var messageBox = new FadingMessageBox
                                     {
                                         StartPosition = FormStartPosition.CenterScreen,
                                         Message = "Auto page refresh has started!"
                                     };
                messageBox.Show();
            }
        }

        private void _timer_Tick(object sender, System.EventArgs e)
        {
            Host.BrowserProperties.Refresh();
            
            //var ieHandle = Host.BrowserProperties.HWND;
            //var screen = Screen.AllScreens[1];
            //Rectangle bounds = screen.Bounds;
            //using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            //var bounds = new Rectangle(0, 0, Host.BrowserProperties.Width, Host.BrowserProperties.Height);
            //using (var bitmap = new Bitmap(bounds.Width, bounds.Height))
            //{
            //    using (var g = Graphics.FromHwnd((System.IntPtr)ieHandle)) //Graphics.FromImage(bitmap))
            //    {
            //        g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);                    
            //    }

            //    string fileName = "ieScreen.png";

            //    bitmap.Save(@"C:\Temp\" + fileName, ImageFormat.Png);
            //}

        }

    }
}

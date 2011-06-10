using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PageRefresher
{
    public partial class FadingMessageBox : Form
    {
        private Timer _timer;

        public FadingMessageBox()
        {
            InitializeComponent();

            _timer = new Timer();
            _timer.Interval = 220;
            _timer.Tick += (sender, e) =>
                               {
                                   if (Opacity <= 0)
                                   {
                                       this.Close();
                                       return;
                                   }
                                   
                                   Opacity = Opacity - 0.10;
                               };
            _timer.Start();
        }

        public string Message { set { txtMessage.Text = value; } }

    }
}

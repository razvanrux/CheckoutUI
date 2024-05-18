using System;
using System.Drawing;
using System.Windows.Forms;

namespace CheckoutUI
{
    public partial class GoodbyeForm : Form
    {
        private System.Windows.Forms.Timer timer;

        public GoodbyeForm()
        {
            InitializeComponent();
            InitializeTimer();
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Normal;
           // this.Size = new Size(1920, 1080);
            //this.StartPosition = FormStartPosition.CenterScreen; // Center the form on the screen
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10000; // 10 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }
    }
}

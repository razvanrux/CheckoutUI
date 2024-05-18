using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckoutUI
{
    public partial class userIdWindow : Form
    {
        public userIdWindow()
        {
            InitializeComponent();
            this.IDInput.KeyPress += new KeyPressEventHandler(this.userInput_KeyPress);
        }
        private void userInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only control characters (like Backspace), digits, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void userIdWindow_Load(object sender, EventArgs e)
        {

        }
    }
}

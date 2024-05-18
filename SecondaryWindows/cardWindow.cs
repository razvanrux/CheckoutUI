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
    public partial class cardWindow : Form
    {
        public cardWindow()
        {
            InitializeComponent();
            this.cardInput.KeyPress += new KeyPressEventHandler(this.cardInput_KeyPress);
        }
        private void cardInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Allow control characters (like Backspace)
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            // Allow only digits and one decimal point
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }

            // Allow only up to two decimal places
            if (char.IsDigit(e.KeyChar))
            {
                int decimalPointIndex = textBox.Text.IndexOf('.');
                if (decimalPointIndex > -1)
                {
                    // Check if the cursor is after the decimal point and there are already two decimal places
                    string decimalPart = textBox.Text.Substring(decimalPointIndex + 1);
                    if (textBox.SelectionStart > decimalPointIndex && decimalPart.Length >= 2)
                    {
                        e.Handled = true;
                        return;
                    }
                }
            }
        }
        private void cardWindow_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class cashWindow : Form
    {
        public decimal PaymentAmount { get; private set; }

        public cashWindow()
        {
            InitializeComponent();
            this.cashInput.KeyPress += new KeyPressEventHandler(this.cashInput_KeyPress);
            this.Cash_OK.Click += new EventHandler(this.Cash_OK_Click);
        }

        private void cashInput_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Cash_OK_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(cashInput.Text, out decimal amount))
            {
                PaymentAmount = amount;
                MessageBox.Show($"Ai platit {amount} RON");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduceti o suma valida.");
            }
        }

        private void cashWindow_Load(object sender, EventArgs e)
        {

        }
    }

}

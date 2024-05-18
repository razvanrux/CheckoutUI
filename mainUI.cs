namespace CheckoutUI
{
    public partial class mainUI : Form
    {
        public mainUI()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            button9.Click += button9_Click;
            buttonDEL.Click += buttonDEL_Click;
            buttonOK.Click += buttonOK_Click;
        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
            cashWindow cash = new cashWindow();
            cash.ShowDialog();
        }

        private void buttonCARD_Click(object sender, EventArgs e)
        {
            cardWindow card = new cardWindow();
            card.ShowDialog();
        }

        private void fidelityCard_Click(object sender, EventArgs e)
        {
            userIdWindow userID = new userIdWindow();
            userID.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (piecesBox.Text.Length < 3) // Limit input to 3 characters (up to 100)
            {
                piecesBox.Text += "1"; // Append "1" to the current text of the piecesBox
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (piecesBox.Text.Length < 3) // Limit input to 3 characters (up to 100)
            {
                piecesBox.Text += "2"; // Append "2" to the current text of the piecesBox
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (piecesBox.Text.Length < 3) // Limit input to 3 characters (up to 100)
            {
                piecesBox.Text += "3"; // Append "3" to the current text of the piecesBox
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (piecesBox.Text.Length < 3) // Limit input to 3 characters (up to 100)
            {
                piecesBox.Text += "4"; // Append "4" to the current text of the piecesBox
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (piecesBox.Text.Length < 3) // Limit input to 3 characters (up to 100)
            {
                piecesBox.Text += "5"; // Append "5" to the current text of the piecesBox
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (piecesBox.Text.Length < 3) // Limit input to 3 characters (up to 100)
            {
                piecesBox.Text += "6"; // Append "6" to the current text of the piecesBox
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (piecesBox.Text.Length < 3) // Limit input to 3 characters (up to 100)
            {
                piecesBox.Text += "7"; // Append "7" to the current text of the piecesBox
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (piecesBox.Text.Length < 3) // Limit input to 3 characters (up to 100)
            {
                piecesBox.Text += "8"; // Append "8" to the current text of the piecesBox
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (piecesBox.Text.Length < 3) // Limit input to 3 characters (up to 100)
            {
                piecesBox.Text += "9"; // Append "9" to the current text of the piecesBox
            }
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            if (piecesBox.Text.Length > 0)
            {
                piecesBox.Text = piecesBox.Text.Substring(0, piecesBox.Text.Length - 1); // Remove the last character
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (piecesBox.Text.Length == 0 || piecesBox.Text[piecesBox.Text.Length - 1] != '0')
            {
                // Append "0" to the current text of the piecesBox
                if (piecesBox.Text.Length < 3) // Limit input to 3 characters (up to 100)
                {
                    piecesBox.Text += "0";
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // TO BE CONTINUED
        }

        private void piecesBox_TextChanged(object sender, EventArgs e)
        {
            if (piecesBox.Text.Length > 3)
            {
                piecesBox.Text = piecesBox.Text.Substring(0, 3);
            }
        }
        private void piecesBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Disable keyboard input
        }
    }
}

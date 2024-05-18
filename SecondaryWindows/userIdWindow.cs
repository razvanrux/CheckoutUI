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
        private mainUI mainForm;
        public userIdWindow(mainUI mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            IDInput.KeyPress -= IDInput_KeyPress;
            ID_OK.Click -= ID_OK_Click;

            IDInput.KeyPress += IDInput_KeyPress;
            ID_OK.Click += ID_OK_Click;
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
        private void IDInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character (Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // If the pressed key is not a digit or Backspace, set Handled to true
                e.Handled = true;
            }
        }

        private void IDInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_OK_Click(object sender, EventArgs e)
        {
            string userID = IDInput.Text;

            if (string.IsNullOrWhiteSpace(userID))
            {
                MessageBox.Show("Nu ai introdus un ID!");
            }
            else
            {
                // DIANA - momentan imi ia numarul pe care-l introduc.
                // Baza de date va avea urmatoarele campuri (+exemplu): (ID: (1), Prenume PrimaLiteraNumeFamilie.: (Matei P.), Numar telefon: (0745219253))
                //Incearca sa schimbi in messagebox sa-ti apara numele persoanei
                MessageBox.Show($"Bine ai venit, {userID}");

                // Hide GuestText and show welcomeLabel and nameLabel in mainUI form
                mainForm.GuestText.Visible = false;
                mainForm.welcomeLabel.Visible = true;
                mainForm.nameLabel.Visible = true;
                mainForm.nameLabel.Text = userID;
                mainForm.ApplyDiscountsToExistingProducts();

                this.Close();
            }
        }

    }
}

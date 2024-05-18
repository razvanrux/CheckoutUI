using System.Globalization;

namespace CheckoutUI
{
    public partial class mainUI : Form
    {
        public mainUI()
        {
            InitializeComponent();
            button1.Click -= button1_Click;
            button2.Click -= button2_Click;
            button3.Click -= button3_Click;
            button4.Click -= button4_Click;
            button5.Click -= button5_Click;
            button6.Click -= button6_Click;
            button7.Click -= button7_Click;
            button8.Click -= button8_Click;
            button9.Click -= button9_Click;
            buttonDEL.Click -= buttonDEL_Click;
            buttonOK.Click -= buttonOK_Click;
            addButton.Click -= addButton_Click;

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
            itemBox.KeyPress += itemBox_KeyPress;

            addButton.Click += addButton_Click;
            discountBox.ReadOnly = true;
            totalBox.ReadOnly = true;

            welcomeLabel.Visible = false;
            nameLabel.Visible = false;

            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[]
    {
        new DataGridViewTextBoxColumn // ID column
        {
            Name = "IdColumn",
            HeaderText = "ID",
            DataPropertyName = "Id", // Set this to the property name in your data source
            AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
            Width = 80 // Adjust width as needed
        },
        new DataGridViewTextBoxColumn // Nume Produs column
        {
            Name = "ProductNameColumn",
            HeaderText = "Nume Produs",
            DataPropertyName = "ProductName", // Set this to the property name in your data source
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, // Fill remaining space
            MinimumWidth = 200 // Minimum width
        },
        new DataGridViewTextBoxColumn // Bucati column
        {
            Name = "QuantityColumn",
            HeaderText = "Bucati",
            DataPropertyName = "Quantity", // Set this to the property name in your data source
            AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
            Width = 100 // Set width to 20% of available space
        },
        new DataGridViewTextBoxColumn // Pret column
        {
            Name = "PriceColumn",
            HeaderText = "Pret",
            DataPropertyName = "Price", // Set this to the property name in your data source
            AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
            Width = 100 // Set width to 20% of available space
        }
    });
        }

        private void buttonCASH_Click(object sender, EventArgs e)
        {
            using (cashWindow cashWindowForm = new cashWindow())
            {
                if (cashWindowForm.ShowDialog() == DialogResult.OK)
                {
                    decimal paymentAmount = cashWindowForm.PaymentAmount;
                    UpdateTotalAfterPayment(paymentAmount);
                }
            }
        }

        private void buttonCARD_Click(object sender, EventArgs e)
        {
            using (cardWindow cardWindowForm = new cardWindow())
            {
                if (cardWindowForm.ShowDialog() == DialogResult.OK)
                {
                    decimal paymentAmount = cardWindowForm.PaymentAmount;
                    UpdateTotalAfterPayment(paymentAmount);
                }
            }
        }

        private void UpdateTotalAfterPayment(decimal paymentAmount)
        {
            if (decimal.TryParse(totalBox.Text, out decimal currentTotal))
            {
                decimal newTotal = currentTotal - paymentAmount;
                totalBox.Text = newTotal.ToString("0.00"); // Format to 2 decimal places

                // Check if the new total is zero or negative
                if (newTotal <= 0)
                {
                    // Reset the main form
                    ResetMainForm();

                    // Close the current form
                    this.Hide();

                    // Open the goodbye form
                    using (GoodbyeForm goodbyeForm = new GoodbyeForm())
                    {
                        // Subscribe to the goodbye form's FormClosed event
                        goodbyeForm.FormClosed += (sender, e) => {
                            // Show the mainUI form again when the goodbye form is closed
                            this.Show();
                        };

                        // Show the goodbye form
                        goodbyeForm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error updating total. Please check the total amount.");
            }
        }



        private void ResetMainForm()
        {
            // Clear the DataGridView
            dataGridViewProducts.Rows.Clear();

            // Reset the totalBox
            totalBox.Text = "0.00";

            // Make sure no user is logged in
            GuestText.Visible = true;
            welcomeLabel.Visible = false;
            nameLabel.Visible = false;

            // Clear any other fields or reset any other state as needed
            itemBox.Text = "";
            discountBox.Text = "";
            // Add any additional reset logic here
        }

        private void fidelityCard_Click(object sender, EventArgs e)
        {
            userIdWindow userID = new userIdWindow(this); // Pass reference to mainUI form
            userID.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int currentNumber;
            if (int.TryParse(piecesBox.Text, out currentNumber))
            {
                int newNumber = currentNumber * 10 + int.Parse(button.Text);
                if (newNumber <= 100)
                {
                    piecesBox.Text = newNumber.ToString();
                }
            }
            else if (piecesBox.Text.Length < 2 || piecesBox.Text != "0")
            {
                piecesBox.Text += button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int currentNumber;
            if (int.TryParse(piecesBox.Text, out currentNumber))
            {
                int newNumber = currentNumber * 10 + int.Parse(button.Text);
                if (newNumber <= 100)
                {
                    piecesBox.Text = newNumber.ToString();
                }
            }
            else if (piecesBox.Text.Length < 2 || piecesBox.Text != "0")
            {
                piecesBox.Text += button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int currentNumber;
            if (int.TryParse(piecesBox.Text, out currentNumber))
            {
                int newNumber = currentNumber * 10 + int.Parse(button.Text);
                if (newNumber <= 100)
                {
                    piecesBox.Text = newNumber.ToString();
                }
            }
            else if (piecesBox.Text.Length < 2 || piecesBox.Text != "0")
            {
                piecesBox.Text += button3.Text;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int currentNumber;
            if (int.TryParse(piecesBox.Text, out currentNumber))
            {
                int newNumber = currentNumber * 10 + int.Parse(button.Text);
                if (newNumber <= 100)
                {
                    piecesBox.Text = newNumber.ToString();
                }
            }
            else if (piecesBox.Text.Length < 2 || piecesBox.Text != "0")
            {
                piecesBox.Text += button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int currentNumber;
            if (int.TryParse(piecesBox.Text, out currentNumber))
            {
                int newNumber = currentNumber * 10 + int.Parse(button.Text);
                if (newNumber <= 100)
                {
                    piecesBox.Text = newNumber.ToString();
                }
            }
            else if (piecesBox.Text.Length < 2 || piecesBox.Text != "0")
            {
                piecesBox.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int currentNumber;
            if (int.TryParse(piecesBox.Text, out currentNumber))
            {
                int newNumber = currentNumber * 10 + int.Parse(button.Text);
                if (newNumber <= 100)
                {
                    piecesBox.Text = newNumber.ToString();
                }
            }
            else if (piecesBox.Text.Length < 2 || piecesBox.Text != "0")
            {
                piecesBox.Text += button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int currentNumber;
            if (int.TryParse(piecesBox.Text, out currentNumber))
            {
                int newNumber = currentNumber * 10 + int.Parse(button.Text);
                if (newNumber <= 100)
                {
                    piecesBox.Text = newNumber.ToString();
                }
            }
            else if (piecesBox.Text.Length < 2 || piecesBox.Text != "0")
            {
                piecesBox.Text += button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int currentNumber;
            if (int.TryParse(piecesBox.Text, out currentNumber))
            {
                int newNumber = currentNumber * 10 + int.Parse(button.Text);
                if (newNumber <= 100)
                {
                    piecesBox.Text = newNumber.ToString();
                }
            }
            else if (piecesBox.Text.Length < 2 || piecesBox.Text != "0")
            {
                piecesBox.Text += button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int currentNumber;
            if (int.TryParse(piecesBox.Text, out currentNumber))
            {
                int newNumber = currentNumber * 10 + int.Parse(button.Text);
                if (newNumber <= 100)
                {
                    piecesBox.Text = newNumber.ToString();
                }
            }
            else if (piecesBox.Text.Length < 2 || piecesBox.Text != "0")
            {
                piecesBox.Text += button9.Text;
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
            Button button = sender as Button;
            int currentNumber;
            if (int.TryParse(piecesBox.Text, out currentNumber))
            {
                int newNumber = currentNumber * 10;
                if (newNumber <= 100)
                {
                    piecesBox.Text = newNumber.ToString();
                }
            }
            else if (piecesBox.Text != "0" && (piecesBox.Text.Length < 2 || piecesBox.Text[piecesBox.Text.Length - 1] != '0'))
            {
                piecesBox.Text += button0.Text;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int numberOfPieces;
            if (int.TryParse(piecesBox.Text, out numberOfPieces))
            {
                if (numberOfPieces == 0)
                {
                    // Remove the product if the quantity is 0
                    if (dataGridViewProducts.SelectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dataGridViewProducts.SelectedRows)
                        {
                            dataGridViewProducts.Rows.Remove(row);
                        }
                        MessageBox.Show("Produs eliminat!");
                    }
                    else
                    {
                        MessageBox.Show("Select a product to remove!");
                    }
                }
                else
                {
                    // Multiply the product quantity and update the price
                    if (dataGridViewProducts.SelectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dataGridViewProducts.SelectedRows)
                        {
                            // Assuming the Quantity is in the third column (index 2) and the Price in the fourth column (index 3)
                            row.Cells[2].Value = numberOfPieces;

                            decimal basePrice = 100; // Assuming the base price is known and static for now
                            decimal discount = (row.Cells[0].Value.ToString() == "1234" && !GuestText.Visible) ? 10 : 0; // Apply discount if guest is not logged in and ID is "1234"
                            decimal totalPrice = (basePrice - discount) * numberOfPieces;
                            row.Cells[3].Value = totalPrice;

                            // Update the discount box text if applicable
                            if (row.Cells[0].Value.ToString() == "1234" && !GuestText.Visible)
                            {
                                discountBox.Text = "-" + (discount * numberOfPieces).ToString();
                            }
                            else
                            {
                                discountBox.Text = "";
                            }
                        }
                        MessageBox.Show(numberOfPieces + " bucati");
                    }
                    else
                    {
                        MessageBox.Show("Select a product to update the quantity!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity entered!");
            }

            // Update the total price
            UpdateTotalPrice();

            // Clear the text in the piecesBox TextBox
            piecesBox.Text = "";

            // Set focus back to the piecesBox TextBox
            piecesBox.Focus();
        }



        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                if (row.Cells[3].Value != null) // Assuming the Price is in the fourth column (index 3)
                {
                    totalPrice += Convert.ToDecimal(row.Cells[3].Value);
                }
            }

            // Display the total price without currency symbol
            totalBox.Text = totalPrice.ToString("N2"); // "N2" for numeric format with 2 decimal places
        }

        public void ApplyDiscountsToExistingProducts()
        {
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                if (row.Cells[0].Value != null) // Assuming the ID is in the first column (index 0)
                {
                    string productId = row.Cells[0].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells[2].Value); // Assuming the Quantity is in the third column (index 2)
                    decimal basePrice = 100; // Assuming the base price is known and static for now
                    decimal discount = 0;

                    if (productId == "1234" && !GuestText.Visible)
                    {
                        discount = 10; // Apply a discount of 10
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        row.DefaultCellStyle.ForeColor = Color.Black; // Reset the text color if no discount
                    }

                    decimal discountedPrice = (basePrice - discount) * quantity;
                    row.Cells[3].Value = discountedPrice; // Assuming the Price is in the fourth column (index 3)

                    // Update the discount box text if applicable
                    if (productId == "1234" && !GuestText.Visible)
                    {
                        discountBox.Text = "-" + (discount * quantity).ToString();
                    }
                    else
                    {
                        discountBox.Text = "";
                    }
                }
            }

            // Update the total price after applying discounts
            UpdateTotalPrice();
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

        private void discountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Disable keyboard input
        }

        private void discountBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void totalBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Disable keyboard input
        }

        private void totalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character (Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // If the pressed key is not a digit or Backspace, set Handled to true
                e.Handled = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // DIANA - aici e buba
            // Tabelul pentru produse: ID (1), Name (Lapte UHT 1L 3.5%), Guest_Price (5.99), Client_Price(4.99)
            // Client_Price se refera la cazul in care exista un discount pentru produsul respectiv
            // Daca nu are discount, Client_Price ramane NULL, iar eu verific daca acord discount la client doar daca nu e null
            // Sa-mi lasi te rog comentarii cum ti am lasat eu gen "RAZVAN -" ca sa gasesc mai usor
            // Vreau sa stiu cum pot accesa baza de date sa verific daca o casuta este NULL sau nu
            // Incearca si testeaza sa vezi daca o sa mearga
            if (!string.IsNullOrEmpty(itemBox.Text))
            {
                // Get the product ID from the itemBox
                string productId = itemBox.Text;
                decimal price = 100;
                decimal discount = 0;
                decimal discountedPrice = price;

                // DIANA - 1234 este ID pentru un produs discounted. Mai sunt o tona de functii care folosesc acest 1234
                // da-i un ctrl f si vezi cam ce ar trebui modificat ca sa acceseze baza de date pliz
                // Check if the product ID is "1234" and if the Guest label is hidden
                if (productId == "1234" && !GuestText.Visible)
                {
                    discount = 10; // Apply a discount of 10
                    discountedPrice = price - discount;
                }

                // Add a new row to the dataGridViewProducts
                int rowIndex = dataGridViewProducts.Rows.Add(productId, productId, 1, discountedPrice);

                // Optionally, you can select the newly added row
                dataGridViewProducts.ClearSelection();
                dataGridViewProducts.Rows[rowIndex].Selected = true;

                // Set the text color to red if there is a discount
                if (productId == "1234" && !GuestText.Visible)
                {
                    dataGridViewProducts.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }

                // Set the discount box text if applicable
                if (productId == "1234" && !GuestText.Visible)
                {
                    discountBox.Text = "-" + discount.ToString();
                }
                else
                {
                    discountBox.Text = "";
                }

                // Update the total price
                UpdateTotalPrice();

                // Clear the text in the itemBox TextBox
                itemBox.Text = "";

                // Set focus back to the itemBox TextBox
                itemBox.Focus();
            }
            else
            {
                // If the itemBox is empty, display a message indicating no product ID has been entered
                MessageBox.Show("Please enter a product ID!");
            }
        }




        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

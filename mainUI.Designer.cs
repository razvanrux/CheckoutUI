namespace CheckoutUI
{
    partial class mainUI
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label labelReduceri;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelBucati;
        private System.Windows.Forms.Button fidelityCard;
        private System.Windows.Forms.Button buttonCash;
        private System.Windows.Forms.Panel keypadPanel;
        private System.Windows.Forms.Button[] keypadButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainUI));
            dataGridViewProducts = new DataGridView();
            labelReduceri = new Label();
            labelTotal = new Label();
            labelBucati = new Label();
            fidelityCard = new Button();
            buttonCash = new Button();
            keypadPanel = new Panel();
            piecesBox = new TextBox();
            buttonOK = new Button();
            button9 = new Button();
            button6 = new Button();
            button3 = new Button();
            button0 = new Button();
            button8 = new Button();
            button5 = new Button();
            button2 = new Button();
            buttonDEL = new Button();
            button7 = new Button();
            button4 = new Button();
            button1 = new Button();
            buttonCARD = new Button();
            UserPanel = new Panel();
            nameLabel = new Label();
            welcomeLabel = new Label();
            GuestText = new Label();
            discountBox = new TextBox();
            totalBox = new TextBox();
            itemBox = new TextBox();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            keypadPanel.SuspendLayout();
            UserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(12, 10);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(993, 946);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
            // 
            // labelReduceri
            // 
            labelReduceri.AutoSize = true;
            labelReduceri.Font = new Font("Segoe UI", 45F);
            labelReduceri.Location = new Point(13, 973);
            labelReduceri.Margin = new Padding(4, 0, 4, 0);
            labelReduceri.Name = "labelReduceri";
            labelReduceri.Size = new Size(264, 81);
            labelReduceri.TabIndex = 3;
            labelReduceri.Text = "Reduceri";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 45F);
            labelTotal.Location = new Point(546, 973);
            labelTotal.Margin = new Padding(4, 0, 4, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(161, 81);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total";
            // 
            // labelBucati
            // 
            labelBucati.AutoSize = true;
            labelBucati.Font = new Font("Segoe UI", 55F);
            labelBucati.Location = new Point(4, 0);
            labelBucati.Margin = new Padding(4, 0, 4, 0);
            labelBucati.Name = "labelBucati";
            labelBucati.Size = new Size(241, 99);
            labelBucati.TabIndex = 5;
            labelBucati.Text = "Bucati";
            // 
            // fidelityCard
            // 
            fidelityCard.Font = new Font("Segoe UI", 30F);
            fidelityCard.Image = (Image)resources.GetObject("fidelityCard.Image");
            fidelityCard.Location = new Point(1022, 10);
            fidelityCard.Margin = new Padding(4, 3, 4, 3);
            fidelityCard.Name = "fidelityCard";
            fidelityCard.Size = new Size(345, 332);
            fidelityCard.TabIndex = 6;
            fidelityCard.Text = "Card de Fidelitate";
            fidelityCard.TextAlign = ContentAlignment.BottomCenter;
            fidelityCard.UseVisualStyleBackColor = true;
            fidelityCard.Click += fidelityCard_Click;
            // 
            // buttonCash
            // 
            buttonCash.BackgroundImage = (Image)resources.GetObject("buttonCash.BackgroundImage");
            buttonCash.BackgroundImageLayout = ImageLayout.Center;
            buttonCash.Font = new Font("Segoe UI", 45F);
            buttonCash.Image = (Image)resources.GetObject("buttonCash.Image");
            buttonCash.ImageAlign = ContentAlignment.TopCenter;
            buttonCash.Location = new Point(1022, 722);
            buttonCash.Margin = new Padding(4, 3, 4, 3);
            buttonCash.Name = "buttonCash";
            buttonCash.Size = new Size(345, 332);
            buttonCash.TabIndex = 7;
            buttonCash.Text = "Plata CASH";
            buttonCash.TextAlign = ContentAlignment.BottomCenter;
            buttonCash.UseVisualStyleBackColor = true;
            buttonCash.Click += buttonCASH_Click;
            // 
            // keypadPanel
            // 
            keypadPanel.BackColor = SystemColors.Control;
            keypadPanel.Controls.Add(piecesBox);
            keypadPanel.Controls.Add(buttonOK);
            keypadPanel.Controls.Add(button9);
            keypadPanel.Controls.Add(button6);
            keypadPanel.Controls.Add(button3);
            keypadPanel.Controls.Add(button0);
            keypadPanel.Controls.Add(labelBucati);
            keypadPanel.Controls.Add(button8);
            keypadPanel.Controls.Add(button5);
            keypadPanel.Controls.Add(button2);
            keypadPanel.Controls.Add(buttonDEL);
            keypadPanel.Controls.Add(button7);
            keypadPanel.Controls.Add(button4);
            keypadPanel.Controls.Add(button1);
            keypadPanel.Location = new Point(1375, 366);
            keypadPanel.Margin = new Padding(4, 3, 4, 3);
            keypadPanel.Name = "keypadPanel";
            keypadPanel.Size = new Size(532, 702);
            keypadPanel.TabIndex = 8;
            // 
            // piecesBox
            // 
            piecesBox.Font = new Font("Segoe UI", 45F);
            piecesBox.Location = new Point(252, 19);
            piecesBox.Name = "piecesBox";
            piecesBox.Size = new Size(252, 87);
            piecesBox.TabIndex = 12;
            piecesBox.TextChanged += piecesBox_TextChanged;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = SystemColors.ControlDark;
            buttonOK.Font = new Font("Segoe UI", 55F);
            buttonOK.Location = new Point(368, 550);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(149, 138);
            buttonOK.TabIndex = 11;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlDark;
            button9.Font = new Font("Segoe UI", 55F);
            button9.Location = new Point(368, 406);
            button9.Name = "button9";
            button9.Size = new Size(151, 138);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDark;
            button6.Font = new Font("Segoe UI", 55F);
            button6.Location = new Point(368, 262);
            button6.Name = "button6";
            button6.Size = new Size(151, 138);
            button6.TabIndex = 9;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Font = new Font("Segoe UI", 55F);
            button3.Location = new Point(368, 112);
            button3.Name = "button3";
            button3.Size = new Size(148, 138);
            button3.TabIndex = 8;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ControlDark;
            button0.Font = new Font("Segoe UI", 55F);
            button0.Location = new Point(191, 550);
            button0.Name = "button0";
            button0.Size = new Size(151, 138);
            button0.TabIndex = 7;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlDark;
            button8.Font = new Font("Segoe UI", 55F);
            button8.Location = new Point(191, 406);
            button8.Name = "button8";
            button8.Size = new Size(151, 138);
            button8.TabIndex = 6;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDark;
            button5.Font = new Font("Segoe UI", 55F);
            button5.Location = new Point(191, 262);
            button5.Name = "button5";
            button5.Size = new Size(148, 138);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Segoe UI", 55F);
            button2.Location = new Point(194, 112);
            button2.Name = "button2";
            button2.Size = new Size(148, 138);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonDEL
            // 
            buttonDEL.BackColor = SystemColors.ControlDark;
            buttonDEL.Font = new Font("Segoe UI", 55F);
            buttonDEL.Location = new Point(12, 550);
            buttonDEL.Name = "buttonDEL";
            buttonDEL.Size = new Size(151, 138);
            buttonDEL.TabIndex = 3;
            buttonDEL.Text = "<-";
            buttonDEL.UseVisualStyleBackColor = false;
            buttonDEL.Click += buttonDEL_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlDark;
            button7.Font = new Font("Segoe UI", 55F);
            button7.Location = new Point(12, 406);
            button7.Name = "button7";
            button7.Size = new Size(151, 138);
            button7.TabIndex = 2;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Font = new Font("Segoe UI", 55F);
            button4.Location = new Point(15, 262);
            button4.Name = "button4";
            button4.Size = new Size(148, 138);
            button4.TabIndex = 1;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Segoe UI", 55F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(12, 112);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(148, 138);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonCARD
            // 
            buttonCARD.Font = new Font("Segoe UI", 45F);
            buttonCARD.Image = (Image)resources.GetObject("buttonCARD.Image");
            buttonCARD.ImageAlign = ContentAlignment.TopCenter;
            buttonCARD.Location = new Point(1022, 366);
            buttonCARD.Margin = new Padding(4, 3, 4, 3);
            buttonCARD.Name = "buttonCARD";
            buttonCARD.Size = new Size(345, 332);
            buttonCARD.TabIndex = 9;
            buttonCARD.Text = "Plata CARD";
            buttonCARD.TextAlign = ContentAlignment.BottomCenter;
            buttonCARD.UseVisualStyleBackColor = true;
            buttonCARD.Click += buttonCARD_Click;
            // 
            // UserPanel
            // 
            UserPanel.BackColor = SystemColors.Control;
            UserPanel.BorderStyle = BorderStyle.FixedSingle;
            UserPanel.Controls.Add(nameLabel);
            UserPanel.Controls.Add(welcomeLabel);
            UserPanel.Controls.Add(GuestText);
            UserPanel.Location = new Point(1379, 10);
            UserPanel.Margin = new Padding(4, 3, 4, 3);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new Size(528, 332);
            UserPanel.TabIndex = 12;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 55F);
            nameLabel.Location = new Point(45, 129);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(0, 99);
            nameLabel.TabIndex = 14;
            nameLabel.Click += nameLabel_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 55F);
            welcomeLabel.Location = new Point(45, 0);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(454, 99);
            welcomeLabel.TabIndex = 13;
            welcomeLabel.Text = "Bine ai venit,";
            welcomeLabel.Click += welcomeLabel_Click;
            // 
            // GuestText
            // 
            GuestText.AutoSize = true;
            GuestText.Font = new Font("Segoe UI", 55F);
            GuestText.Location = new Point(150, 109);
            GuestText.Margin = new Padding(4, 0, 4, 0);
            GuestText.Name = "GuestText";
            GuestText.Size = new Size(230, 99);
            GuestText.TabIndex = 12;
            GuestText.Text = "Guest";
            // 
            // discountBox
            // 
            discountBox.Font = new Font("Segoe UI", 45F);
            discountBox.Location = new Point(284, 970);
            discountBox.Name = "discountBox";
            discountBox.Size = new Size(255, 87);
            discountBox.TabIndex = 13;
            discountBox.TextChanged += discountBox_TextChanged;
            // 
            // totalBox
            // 
            totalBox.Font = new Font("Segoe UI", 45F);
            totalBox.Location = new Point(714, 970);
            totalBox.Name = "totalBox";
            totalBox.Size = new Size(289, 87);
            totalBox.TabIndex = 14;
            totalBox.TextChanged += totalBox_TextChanged;
            // 
            // itemBox
            // 
            itemBox.Font = new Font("Segoe UI", 40F);
            itemBox.Location = new Point(12, 878);
            itemBox.Name = "itemBox";
            itemBox.Size = new Size(855, 78);
            itemBox.TabIndex = 15;
            itemBox.TextChanged += itemBox_TextChanged;
            // 
            // addButton
            // 
            addButton.BackgroundImageLayout = ImageLayout.None;
            addButton.Font = new Font("Segoe UI", 20F);
            addButton.ImageAlign = ContentAlignment.BottomCenter;
            addButton.Location = new Point(866, 878);
            addButton.Name = "addButton";
            addButton.Size = new Size(139, 78);
            addButton.TabIndex = 16;
            addButton.Text = "Adauga";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // mainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(addButton);
            Controls.Add(itemBox);
            Controls.Add(totalBox);
            Controls.Add(discountBox);
            Controls.Add(UserPanel);
            Controls.Add(buttonCARD);
            Controls.Add(dataGridViewProducts);
            Controls.Add(labelReduceri);
            Controls.Add(labelTotal);
            Controls.Add(fidelityCard);
            Controls.Add(buttonCash);
            Controls.Add(keypadPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "mainUI";
            Text = "Welcome";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            keypadPanel.ResumeLayout(false);
            keypadPanel.PerformLayout();
            UserPanel.ResumeLayout(false);
            UserPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button4;
        private Button button6;
        private Button button3;
        private Button button5;
        private Button button2;
        private Button buttonCARD;
        private Button buttonOK;
        private Button button9;
        private Button button0;
        private Button button8;
        private Button buttonDEL;
        private Button button7;
        private Panel UserPanel;
        public Label GuestText;
        private TextBox piecesBox;
        private TextBox discountBox;
        private TextBox totalBox;
        private TextBox itemBox;
        private Button addButton;
        public Label welcomeLabel;
        public Label nameLabel;
    }
}

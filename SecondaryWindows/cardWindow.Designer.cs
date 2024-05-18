namespace CheckoutUI
{
    partial class cardWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardWindow));
            CardLabel = new Label();
            cardInput = new TextBox();
            Card_OK = new Button();
            SuspendLayout();
            // 
            // CardLabel
            // 
            CardLabel.AutoSize = true;
            CardLabel.BackColor = Color.White;
            CardLabel.Font = new Font("Segoe UI", 65F);
            CardLabel.Location = new Point(227, 26);
            CardLabel.Name = "CardLabel";
            CardLabel.Size = new Size(714, 116);
            CardLabel.TabIndex = 2;
            CardLabel.Text = "Introduceti suma:";
            // 
            // cardInput
            // 
            cardInput.Font = new Font("Segoe UI", 75F);
            cardInput.Location = new Point(227, 203);
            cardInput.Name = "cardInput";
            cardInput.Size = new Size(738, 141);
            cardInput.TabIndex = 3;
            // 
            // Card_OK
            // 
            Card_OK.Font = new Font("Segoe UI", 65F);
            Card_OK.Location = new Point(420, 367);
            Card_OK.Name = "Card_OK";
            Card_OK.Size = new Size(351, 239);
            Card_OK.TabIndex = 4;
            Card_OK.Text = "OK";
            Card_OK.UseVisualStyleBackColor = true;
            Card_OK.Click += Card_OK_Click;
            // 
            // cardWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1178, 618);
            Controls.Add(Card_OK);
            Controls.Add(cardInput);
            Controls.Add(CardLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cardWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cardWindow";
            Load += cardWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CardLabel;
        private TextBox cardInput;
        private Button Card_OK;
    }
}
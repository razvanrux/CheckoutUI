namespace CheckoutUI
{
    partial class cashWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashWindow));
            Cash_OK = new Button();
            CashLabel = new Label();
            cashInput = new TextBox();
            SuspendLayout();
            // 
            // Cash_OK
            // 
            Cash_OK.Font = new Font("Segoe UI", 65F);
            Cash_OK.Location = new Point(674, 446);
            Cash_OK.Name = "Cash_OK";
            Cash_OK.Size = new Size(351, 239);
            Cash_OK.TabIndex = 0;
            Cash_OK.Text = "OK";
            Cash_OK.UseVisualStyleBackColor = true;
            // 
            // CashLabel
            // 
            CashLabel.AutoSize = true;
            CashLabel.Font = new Font("Segoe UI", 65F);
            CashLabel.Location = new Point(483, 47);
            CashLabel.Name = "CashLabel";
            CashLabel.Size = new Size(714, 116);
            CashLabel.TabIndex = 1;
            CashLabel.Text = "Introduceti suma:";
            // 
            // cashInput
            // 
            cashInput.Font = new Font("Segoe UI", 75F);
            cashInput.Location = new Point(467, 224);
            cashInput.Name = "cashInput";
            cashInput.Size = new Size(753, 141);
            cashInput.TabIndex = 2;
            // 
            // cashWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1671, 758);
            Controls.Add(cashInput);
            Controls.Add(CashLabel);
            Controls.Add(Cash_OK);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cashWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cashWindow";
            Load += cashWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cash_OK;
        private Label CashLabel;
        private TextBox cashInput;
    }
}
namespace CheckoutUI
{
    partial class userIdWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userIdWindow));
            IDLabel = new Label();
            IDInput = new TextBox();
            ID_OK = new Button();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 65F);
            IDLabel.Location = new Point(108, 9);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(1047, 116);
            IDLabel.TabIndex = 2;
            IDLabel.Text = "Introduceti ID-ul de client:";
            // 
            // IDInput
            // 
            IDInput.Font = new Font("Segoe UI", 75F);
            IDInput.Location = new Point(147, 163);
            IDInput.Name = "IDInput";
            IDInput.Size = new Size(1008, 141);
            IDInput.TabIndex = 3;
            // 
            // ID_OK
            // 
            ID_OK.Font = new Font("Segoe UI", 65F);
            ID_OK.Location = new Point(485, 351);
            ID_OK.Name = "ID_OK";
            ID_OK.Size = new Size(351, 239);
            ID_OK.TabIndex = 4;
            ID_OK.Text = "OK";
            ID_OK.UseVisualStyleBackColor = true;
            // 
            // userIdWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1267, 617);
            Controls.Add(ID_OK);
            Controls.Add(IDInput);
            Controls.Add(IDLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userIdWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userIdWindow";
            Load += userIdWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDLabel;
        private TextBox IDInput;
        private Button ID_OK;
    }
}
namespace CheckoutUI
{
    partial class GoodbyeForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodbyeForm));
            countdown = new System.Windows.Forms.Timer(components);
            messageLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI", 65F);
            messageLabel.Location = new Point(423, 187);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(968, 116);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "Multumim pentru vizita!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(77, 567);
            label1.Name = "label1";
            label1.Size = new Size(1733, 72);
            label1.TabIndex = 1;
            label1.Text = "Te rugam sa astepti clientul precedent pentru a-si prelua cumparaturile!";
            // 
            // GoodbyeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1080);
            Controls.Add(label1);
            Controls.Add(messageLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GoodbyeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GoodbyeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer countdown;
        private Label messageLabel;
        private Label label1;
    }
}
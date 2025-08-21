namespace Basic_Queuing_Cashier
{
    partial class CustomerView
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
            lblNowServing = new Label();
            lblNowServingText = new Label();
            SuspendLayout();
            // 
            // lblNowServing
            // 
            lblNowServing.AutoSize = true;
            lblNowServing.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblNowServing.Location = new Point(100, 120);
            lblNowServing.Name = "lblNowServing";
            lblNowServing.Size = new Size(161, 45);
            lblNowServing.TabIndex = 0;
            lblNowServing.Text = "P - 00000";
            // 
            // lblNowServingText
            // 
            lblNowServingText.AutoSize = true;
            lblNowServingText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblNowServingText.Location = new Point(100, 60);
            lblNowServingText.Name = "lblNowServingText";
            lblNowServingText.Size = new Size(183, 32);
            lblNowServingText.TabIndex = 1;
            lblNowServingText.Text = "*Now Serving*";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 250);
            Controls.Add(lblNowServingText);
            Controls.Add(lblNowServing);
            Name = "CustomerView";
            Text = "JZRCustomerView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNowServing;
        private System.Windows.Forms.Label lblNowServingText;
    }
}

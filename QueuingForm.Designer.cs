namespace Basic_Queuing_Cashier
{
    partial class QueuingForm
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
            btnCashier = new Button();
            lblQueue = new Label();
            lblPosition = new Label();
            lblHint = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Location = new Point(50, 100);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(120, 40);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblQueue.Location = new Point(250, 120);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(161, 45);
            lblQueue.TabIndex = 1;
            lblQueue.Text = "P - 00000";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 12F);
            lblPosition.Location = new Point(250, 80);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(132, 21);
            lblPosition.TabIndex = 2;
            lblPosition.Text = "Position in Queue";
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Font = new Font("Segoe UI", 8F);
            lblHint.ForeColor = Color.Red;
            lblHint.Location = new Point(50, 150);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(122, 13);
            lblHint.TabIndex = 3;
            lblHint.Text = "*Click to get a number";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 250);
            Controls.Add(lblHint);
            Controls.Add(lblPosition);
            Controls.Add(lblQueue);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            Text = "JZRQueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblHint;
    }
}

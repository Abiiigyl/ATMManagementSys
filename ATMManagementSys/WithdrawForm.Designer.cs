namespace ATMManagementSys
{
    partial class WithdrawForm
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
            btnWithdraw = new Button();
            btnCancel = new Button();
            lblWithdraw = new Label();
            txtAmount = new TextBox();
            SuspendLayout();
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(198, 243);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(112, 34);
            btnWithdraw.TabIndex = 0;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(431, 243);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblWithdraw
            // 
            lblWithdraw.AutoSize = true;
            lblWithdraw.Location = new Point(304, 74);
            lblWithdraw.Name = "lblWithdraw";
            lblWithdraw.Size = new Size(158, 25);
            lblWithdraw.TabIndex = 2;
            lblWithdraw.Text = "Withdraw Amount";
            lblWithdraw.Click += lblWithdraw_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(304, 160);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 31);
            txtAmount.TabIndex = 3;
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAmount);
            Controls.Add(lblWithdraw);
            Controls.Add(btnCancel);
            Controls.Add(btnWithdraw);
            Name = "WithdrawForm";
            Text = "WithdrawForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWithdraw;
        private Button btnCancel;
        private Label lblWithdraw;
        private TextBox txtAmount;
    }
}
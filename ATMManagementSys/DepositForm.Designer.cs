namespace ATMManagementSys
{
    partial class DepositForm
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
            lblDeposit = new Label();
            txtAmount = new TextBox();
            btnDeposit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Location = new Point(339, 68);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(144, 25);
            lblDeposit.TabIndex = 0;
            lblDeposit.Text = "Deposit Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(333, 145);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 31);
            txtAmount.TabIndex = 1;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(210, 242);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(112, 34);
            btnDeposit.TabIndex = 2;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(415, 242);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // DepositForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnDeposit);
            Controls.Add(txtAmount);
            Controls.Add(lblDeposit);
            Name = "DepositForm";
            Text = "DepositForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label lblDeposit;
        private TextBox tex;
        private TextBox txtAmount;
        private Button btnDeposit;
        private Button btnCancel;
    }
}
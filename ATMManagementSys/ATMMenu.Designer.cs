namespace ATMManagementSys
{
    partial class ATMMenu
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
            lblWelcome = new Label();
            btnBalance = new Button();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(349, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(85, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            lblWelcome.Click += label1_Click;
            // 
            // btnBalance
            // 
            btnBalance.Location = new Point(322, 101);
            btnBalance.Name = "btnBalance";
            btnBalance.Size = new Size(112, 34);
            btnBalance.TabIndex = 1;
            btnBalance.Text = "Balance";
            btnBalance.UseVisualStyleBackColor = true;
            btnBalance.Click += btnBalance_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(322, 183);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(112, 34);
            btnDeposit.TabIndex = 2;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(322, 261);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(112, 34);
            btnWithdraw.TabIndex = 3;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(322, 340);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // ATMMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(btnBalance);
            Controls.Add(lblWelcome);
            Name = "ATMMenu";
            Text = "ATMMenu";
            Load += ATMMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnBalance;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnLogout;
    }
}
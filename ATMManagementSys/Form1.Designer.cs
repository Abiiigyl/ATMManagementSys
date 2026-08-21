namespace ATMManagementSys
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnLogin = new Button();
            txtAccount = new TextBox();
            txtPIN = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 59);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "ATM Login";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 142);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 1;
            label2.Text = "Accout Number:";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 230);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 2;
            label3.Text = "PIN Number:";
            label3.UseWaitCursor = true;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(236, 333);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(112, 34);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.UseWaitCursor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(319, 142);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(150, 31);
            txtAccount.TabIndex = 4;
            txtAccount.UseWaitCursor = true;
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(319, 230);
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(150, 31);
            txtPIN.TabIndex = 5;
            txtPIN.UseWaitCursor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPIN);
            Controls.Add(txtAccount);
            Controls.Add(BtnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "ATM Login";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnLogin;
        private TextBox txtAccount;
        private TextBox txtPIN;
    }
}

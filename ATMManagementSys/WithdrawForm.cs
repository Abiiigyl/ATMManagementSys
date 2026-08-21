using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ATMManagementSys
{
    public partial class WithdrawForm : Form
    {
        private string accountNumber;
        public WithdrawForm()
        {
            InitializeComponent();
        }
        public WithdrawForm(string account)
        {
            InitializeComponent();
            accountNumber = account;
        }

        private void lblWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    decimal amount = Convert.ToDecimal(txtAmount.Text);

                    // Check current balance
                    string balanceQuery = "SELECT balance FROM accounts WHERE account_number=@account";

                    MySqlCommand balanceCmd = new MySqlCommand(balanceQuery, conn);
                    balanceCmd.Parameters.AddWithValue("@account", accountNumber);

                    decimal balance = Convert.ToDecimal(balanceCmd.ExecuteScalar());

                    if (amount > balance)
                    {
                        MessageBox.Show("Insufficient Funds!");
                        return;
                    }

                    // Update balance
                    string withdrawQuery = "UPDATE accounts SET balance = balance - @amount WHERE account_number=@account";

                    MySqlCommand withdrawCmd = new MySqlCommand(withdrawQuery, conn);

                    withdrawCmd.Parameters.AddWithValue("@amount", amount);
                    withdrawCmd.Parameters.AddWithValue("@account", accountNumber);

                    withdrawCmd.ExecuteNonQuery();

                    MessageBox.Show("Withdrawal Successful!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

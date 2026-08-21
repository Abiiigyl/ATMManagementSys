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
    public partial class DepositForm : Form
    {
        private string accountNumber;
        public DepositForm()
        {
            InitializeComponent();
        }
        public DepositForm(string account)
        {
            InitializeComponent();
            accountNumber = account;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        { 
        
            Database db = new Database();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    decimal amount = Convert.ToDecimal(txtAmount.Text);

                    string query = "UPDATE accounts SET balance = balance + @amount WHERE account_number = @account";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@account", accountNumber);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deposit Successful!");

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


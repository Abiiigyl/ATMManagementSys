using System;
using MySql.Data.MySqlClient;

namespace ATMManagementSys
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM accounts WHERE account_number=@account AND pin=@pin";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@account", txtAccount.Text);
                    cmd.Parameters.AddWithValue("@pin", txtPIN.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        ATMMenu menu = new ATMMenu(txtAccount.Text, this);
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account Number or PIN!");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

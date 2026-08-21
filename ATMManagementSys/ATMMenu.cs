using MySql.Data.MySqlClient;

namespace ATMManagementSys
{
    public partial class ATMMenu : Form
    {
        private string accountNumber;
        private LoginForm loginForm;
        public ATMMenu()
        {
            InitializeComponent();
        }
        public ATMMenu(string account, LoginForm form)
        {
            InitializeComponent();

            accountNumber = account;
            loginForm = form;
        }
        private void LoadCustomer()
        {
            Database db = new Database();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT account_name FROM accounts WHERE account_number=@account";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@account", accountNumber);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    lblWelcome.Text = "Welcome " + result.ToString();
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ATMMenu_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT balance FROM accounts WHERE account_number=@account";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@account", accountNumber);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        MessageBox.Show(
                            "Current Balance: KES " + Convert.ToDecimal(result).ToString("N2"),
                            "Balance");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm deposit = new DepositForm(accountNumber);
            deposit.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm withdraw = new WithdrawForm(accountNumber);
            withdraw.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();

                this.Close();
            }
        }
    }

}

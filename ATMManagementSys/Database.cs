using MySql.Data.MySqlClient;

namespace ATMManagementSys
{
    public class Database
    {
        // Connection string
        private string connectionString =
            "server=localhost;database=atmdb;uid=root;pwd=;";

        // Method to get database connection
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

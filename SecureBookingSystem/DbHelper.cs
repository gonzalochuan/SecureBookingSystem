using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace SecureBookingSystem
{
    public static class DbHelper
    {
        public static string ConnectionString = "server=localhost;user=root;password=;database=secure_booking;";

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
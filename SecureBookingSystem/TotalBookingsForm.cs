using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SecureBookingSystem
{
    public partial class TotalBookingsForm : Form
    {
        public TotalBookingsForm()
        {
            InitializeComponent();
            LoadSummary();
        }

        private void LoadSummary()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var cmd = new MySqlCommand("SELECT status, COUNT(*) as Total FROM bookings GROUP BY status", conn);
                var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dgvSummary.DataSource = dt;

                cmd = new MySqlCommand("SELECT COUNT(*) FROM bookings", conn);
                lblTotal.Text = "Total Bookings: " + cmd.ExecuteScalar().ToString();
            }
        }
    }
}
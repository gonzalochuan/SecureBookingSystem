using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SecureBookingSystem
{
    public partial class BookingLocationsForm : Form
    {
        public BookingLocationsForm()
        {
            InitializeComponent();
            LoadLocations();
        }

        private void LoadLocations()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var cmd = new MySqlCommand("SELECT location, COUNT(*) as Total FROM bookings GROUP BY location", conn);
                var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dgvLocations.DataSource = dt;
            }
        }
    }
}
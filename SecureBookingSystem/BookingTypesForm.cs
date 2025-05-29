using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SecureBookingSystem
{
    public partial class BookingTypesForm : Form
    {
        public BookingTypesForm()
        {
            InitializeComponent();
            LoadTypes();
        }

        private void LoadTypes()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var cmd = new MySqlCommand("SELECT type, COUNT(*) as Total FROM bookings GROUP BY type", conn);
                var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dgvTypes.DataSource = dt;
            }
        }
    }
}
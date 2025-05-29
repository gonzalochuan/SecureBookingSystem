using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text;

namespace SecureBookingSystem
{
    public partial class BookingViewAllForm : Form
    {
        public BookingViewAllForm()
        {
            InitializeComponent();
            LoadAllBookings();
        }

        private void LoadAllBookings()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var cmd = new MySqlCommand(
                    "SELECT b.id, u.username, b.booking_date, b.details, b.location, b.status, b.type " +
                    "FROM bookings b JOIN users u ON b.user_id = u.id " +
                    "ORDER BY b.booking_date DESC", conn);
                var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dgvAllBookings.DataSource = dt;
            }
        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            if (dgvAllBookings.DataSource == null)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "Bookings.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataTable dt = (DataTable)dgvAllBookings.DataSource;
                        StringBuilder sb = new StringBuilder();

                        // Write headers
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            sb.Append(dt.Columns[i]);
                            if (i < dt.Columns.Count - 1)
                                sb.Append(",");
                        }
                        sb.AppendLine();

                        // Write data
                        foreach (DataRow row in dt.Rows)
                        {
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                sb.Append(row[i].ToString().Replace(",", " "));
                                if (i < dt.Columns.Count - 1)
                                    sb.Append(",");
                            }
                            sb.AppendLine();
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("List saved successfully. You can open it in Excel.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message);
                    }
                }
            }
        }
    }
}
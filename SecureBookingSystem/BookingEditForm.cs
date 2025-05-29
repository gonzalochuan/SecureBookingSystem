using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Windows.Forms;

namespace SecureBookingSystem
{
    public partial class BookingEditForm : Form
    {
        private int userId;
        private int? bookingId = null;

        public BookingEditForm(int userId, int? bookingId = null)
        {
            InitializeComponent();
            this.userId = userId;
            this.bookingId = bookingId;
            if (bookingId.HasValue)
                LoadBooking();
        }

        private void LoadBooking()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var cmd = new MySqlCommand("SELECT booking_date, details, location, status, type FROM bookings WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", bookingId.Value);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dtpDate.Value = reader.GetDateTime("booking_date");
                        txtDetails.Text = reader.GetString("details");
                        txtLocation.Text = reader.GetString("location");
                        cmbStatus.SelectedItem = reader.GetString("status");
                        cmbType.SelectedItem = reader.GetString("type");
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDetails.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) ||
                cmbStatus.SelectedIndex == -1 ||
                cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            using (var conn = DbHelper.GetConnection())
            {
                if (bookingId.HasValue)
                {
                    var cmd = new MySqlCommand(
                        "UPDATE bookings SET booking_date=@date, details=@details, location=@location, status=@status, type=@type WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@details", txtDetails.Text);
                    cmd.Parameters.AddWithValue("@location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@id", bookingId.Value);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    var cmd = new MySqlCommand(
                        "INSERT INTO bookings (user_id, booking_date, details, location, status, type) VALUES (@uid, @date, @details, @location, @status, @type)", conn);
                    cmd.Parameters.AddWithValue("@uid", userId);
                    cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@details", txtDetails.Text);
                    cmd.Parameters.AddWithValue("@location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}
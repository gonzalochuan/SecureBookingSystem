using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SecureBookingSystem
{
    public partial class UserEditForm : Form
    {
        private int? userId = null;

        public UserEditForm(int? id = null)
        {
            InitializeComponent();
            userId = id;
            if (userId.HasValue)
                LoadUser();
        }

        private void LoadUser()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var cmd = new MySqlCommand("SELECT username, role FROM users WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", userId.Value);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtUsername.Text = reader.GetString("username");
                        cmbRole.SelectedItem = reader.GetString("role");
                        txtPassword.Enabled = false; // Don't allow password change here for simplicity
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Fill all fields.");
                return;
            }

            using (var conn = DbHelper.GetConnection())
            {
                if (userId.HasValue)
                {
                    var cmd = new MySqlCommand("UPDATE users SET username=@u, role=@r WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@r", cmbRole.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@id", userId.Value);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        MessageBox.Show("Password required for new user.");
                        return;
                    }
                    var cmd = new MySqlCommand("INSERT INTO users (username, password, role) VALUES (@u, SHA2(@p,256), @r)", conn);
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@r", cmbRole.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SecureBookingSystem
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var cmd = new MySqlCommand("SELECT id, username, role, created_at FROM users", conn);
                var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new UserEditForm();
            if (f.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["id"].Value);
            var f = new UserEditForm(id);
            if (f.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["id"].Value);
            if (MessageBox.Show("Delete this user?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var conn = DbHelper.GetConnection())
                {
                    var cmd = new MySqlCommand("DELETE FROM users WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                LoadUsers();
            }
        }
    }
}
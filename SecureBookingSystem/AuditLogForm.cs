using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SecureBookingSystem
{
    public partial class AuditLogForm : Form
    {
        public AuditLogForm()
        {
            InitializeComponent();
            LoadAuditLog();
        }

        private void LoadAuditLog()
        {
            using (var conn = DbHelper.GetConnection())
            {
                var cmd = new MySqlCommand(
                    "SELECT a.id, u.username, a.action, a.timestamp " +
                    "FROM audit_log a LEFT JOIN users u ON a.user_id = u.id " +
                    "ORDER BY a.timestamp DESC", conn);
                var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dgvAudit.DataSource = dt;
            }
        }
    }
}
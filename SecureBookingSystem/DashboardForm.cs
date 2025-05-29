using System;
using System.Windows.Forms;

namespace SecureBookingSystem
{
    public partial class DashboardForm : Form
    {
        private int userId;
        private string role;

        public DashboardForm(int userId, string role)
        {
            InitializeComponent();
            this.userId = userId;
            this.role = role;
            btnUsers.Visible = role == "admin";
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            new BookingEditForm(userId).ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new UsersForm().ShowDialog();
        }

        private void btnAuditLog_Click(object sender, EventArgs e)
        {
            new AuditLogForm().ShowDialog();
        }
        private void btnTotalBookings_Click(object sender, EventArgs e)
        {
            new TotalBookingsForm().ShowDialog();
        }

        private void btnBookingTypes_Click(object sender, EventArgs e)
        {
            new BookingTypesForm().ShowDialog();
        }

        private void btnBookingLocations_Click(object sender, EventArgs e)
        {
            new BookingLocationsForm().ShowDialog();
        }
        private void btnViewAllBookings_Click(object sender, EventArgs e)
        {
            new BookingViewAllForm().ShowDialog();
        }
    }
}
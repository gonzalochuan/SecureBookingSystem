namespace SecureBookingSystem
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnAuditLog;
        private System.Windows.Forms.Button btnTotalBookings;
        private System.Windows.Forms.Button btnBookingTypes;
        private System.Windows.Forms.Button btnBookingLocations;
        private System.Windows.Forms.Button btnViewAllBookings;

        private void InitializeComponent()
        {
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAuditLog = new System.Windows.Forms.Button();
            this.btnTotalBookings = new System.Windows.Forms.Button();
            this.btnBookingTypes = new System.Windows.Forms.Button();
            this.btnBookingLocations = new System.Windows.Forms.Button();
            this.btnViewAllBookings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBookings
            // 
            this.btnBookings.Location = new System.Drawing.Point(30, 30);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(200, 40);
            this.btnBookings.TabIndex = 0;
            this.btnBookings.Text = "Manage Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(30, 80);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(200, 40);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Manage Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnAuditLog
            // 
            this.btnAuditLog.Location = new System.Drawing.Point(30, 130);
            this.btnAuditLog.Name = "btnAuditLog";
            this.btnAuditLog.Size = new System.Drawing.Size(200, 40);
            this.btnAuditLog.TabIndex = 2;
            this.btnAuditLog.Text = "View Audit Log";
            this.btnAuditLog.UseVisualStyleBackColor = true;
            this.btnAuditLog.Click += new System.EventHandler(this.btnAuditLog_Click);
            // 
            // btnTotalBookings
            // 
            this.btnTotalBookings.Location = new System.Drawing.Point(30, 180);
            this.btnTotalBookings.Name = "btnTotalBookings";
            this.btnTotalBookings.Size = new System.Drawing.Size(200, 40);
            this.btnTotalBookings.TabIndex = 3;
            this.btnTotalBookings.Text = "Total Bookings";
            this.btnTotalBookings.UseVisualStyleBackColor = true;
            this.btnTotalBookings.Click += new System.EventHandler(this.btnTotalBookings_Click);
            // 
            // btnBookingTypes
            // 
            this.btnBookingTypes.Location = new System.Drawing.Point(30, 230);
            this.btnBookingTypes.Name = "btnBookingTypes";
            this.btnBookingTypes.Size = new System.Drawing.Size(200, 40);
            this.btnBookingTypes.TabIndex = 4;
            this.btnBookingTypes.Text = "Booking Types";
            this.btnBookingTypes.UseVisualStyleBackColor = true;
            this.btnBookingTypes.Click += new System.EventHandler(this.btnBookingTypes_Click);
            // 
            // btnBookingLocations
            // 
            this.btnBookingLocations.Location = new System.Drawing.Point(30, 280);
            this.btnBookingLocations.Name = "btnBookingLocations";
            this.btnBookingLocations.Size = new System.Drawing.Size(200, 40);
            this.btnBookingLocations.TabIndex = 5;
            this.btnBookingLocations.Text = "Booking Locations";
            this.btnBookingLocations.UseVisualStyleBackColor = true;
            this.btnBookingLocations.Click += new System.EventHandler(this.btnBookingLocations_Click);
            // 
            // btnViewAllBookings
            // 
            this.btnViewAllBookings.Location = new System.Drawing.Point(30, 326);
            this.btnViewAllBookings.Name = "btnViewAllBookings";
            this.btnViewAllBookings.Size = new System.Drawing.Size(200, 39);
            this.btnViewAllBookings.TabIndex = 6;
            this.btnViewAllBookings.Text = "View All Bookings";
            this.btnViewAllBookings.UseVisualStyleBackColor = true;
            this.btnViewAllBookings.Click += new System.EventHandler(this.btnViewAllBookings_Click);
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(258, 377);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnAuditLog);
            this.Controls.Add(this.btnTotalBookings);
            this.Controls.Add(this.btnBookingTypes);
            this.Controls.Add(this.btnBookingLocations);
            this.Controls.Add(this.btnViewAllBookings);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }
    }
}
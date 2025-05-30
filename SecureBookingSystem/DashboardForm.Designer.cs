namespace SecureBookingSystem
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnAuditLog;
        private System.Windows.Forms.Button btnTotalBookings;
        private System.Windows.Forms.Button btnBookingTypes;
        private System.Windows.Forms.Button btnBookingLocations;
        private System.Windows.Forms.Button btnViewAllBookings;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAuditLog = new System.Windows.Forms.Button();
            this.btnTotalBookings = new System.Windows.Forms.Button();
            this.btnBookingTypes = new System.Windows.Forms.Button();
            this.btnBookingLocations = new System.Windows.Forms.Button();
            this.btnViewAllBookings = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 70;
            this.panelHeader.Controls.Add(this.lblTitle);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Dashboard";
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBookings.ForeColor = System.Drawing.Color.White;
            this.btnBookings.Location = new System.Drawing.Point(40, 100);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(250, 45);
            this.btnBookings.TabIndex = 0;
            this.btnBookings.Text = "Manage Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(40, 155);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(250, 45);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Manage Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnAuditLog
            // 
            this.btnAuditLog.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAuditLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditLog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAuditLog.ForeColor = System.Drawing.Color.White;
            this.btnAuditLog.Location = new System.Drawing.Point(40, 210);
            this.btnAuditLog.Name = "btnAuditLog";
            this.btnAuditLog.Size = new System.Drawing.Size(250, 45);
            this.btnAuditLog.TabIndex = 2;
            this.btnAuditLog.Text = "View Audit Log";
            this.btnAuditLog.UseVisualStyleBackColor = false;
            this.btnAuditLog.Click += new System.EventHandler(this.btnAuditLog_Click);
            // 
            // btnTotalBookings
            // 
            this.btnTotalBookings.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnTotalBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalBookings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTotalBookings.ForeColor = System.Drawing.Color.White;
            this.btnTotalBookings.Location = new System.Drawing.Point(40, 265);
            this.btnTotalBookings.Name = "btnTotalBookings";
            this.btnTotalBookings.Size = new System.Drawing.Size(250, 45);
            this.btnTotalBookings.TabIndex = 3;
            this.btnTotalBookings.Text = "Total Bookings";
            this.btnTotalBookings.UseVisualStyleBackColor = false;
            this.btnTotalBookings.Click += new System.EventHandler(this.btnTotalBookings_Click);
            // 
            // btnBookingTypes
            // 
            this.btnBookingTypes.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnBookingTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingTypes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBookingTypes.ForeColor = System.Drawing.Color.White;
            this.btnBookingTypes.Location = new System.Drawing.Point(40, 320);
            this.btnBookingTypes.Name = "btnBookingTypes";
            this.btnBookingTypes.Size = new System.Drawing.Size(250, 45);
            this.btnBookingTypes.TabIndex = 4;
            this.btnBookingTypes.Text = "Booking Types";
            this.btnBookingTypes.UseVisualStyleBackColor = false;
            this.btnBookingTypes.Click += new System.EventHandler(this.btnBookingTypes_Click);
            // 
            // btnBookingLocations
            // 
            this.btnBookingLocations.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnBookingLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingLocations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBookingLocations.ForeColor = System.Drawing.Color.White;
            this.btnBookingLocations.Location = new System.Drawing.Point(40, 375);
            this.btnBookingLocations.Name = "btnBookingLocations";
            this.btnBookingLocations.Size = new System.Drawing.Size(250, 45);
            this.btnBookingLocations.TabIndex = 5;
            this.btnBookingLocations.Text = "Booking Locations";
            this.btnBookingLocations.UseVisualStyleBackColor = false;
            this.btnBookingLocations.Click += new System.EventHandler(this.btnBookingLocations_Click);
            // 
            // btnViewAllBookings
            // 
            this.btnViewAllBookings.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnViewAllBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllBookings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnViewAllBookings.ForeColor = System.Drawing.Color.White;
            this.btnViewAllBookings.Location = new System.Drawing.Point(40, 430);
            this.btnViewAllBookings.Name = "btnViewAllBookings";
            this.btnViewAllBookings.Size = new System.Drawing.Size(250, 45);
            this.btnViewAllBookings.TabIndex = 6;
            this.btnViewAllBookings.Text = "View All Bookings";
            this.btnViewAllBookings.UseVisualStyleBackColor = false;
            this.btnViewAllBookings.Click += new System.EventHandler(this.btnViewAllBookings_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(330, 510);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnAuditLog);
            this.Controls.Add(this.btnTotalBookings);
            this.Controls.Add(this.btnBookingTypes);
            this.Controls.Add(this.btnBookingLocations);
            this.Controls.Add(this.btnViewAllBookings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
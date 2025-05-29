namespace SecureBookingSystem
{
    partial class BookingEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(20, 20);
            this.lblDate.Size = new System.Drawing.Size(80, 20);
            this.lblDate.Text = "Booking Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(120, 20);
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            // 
            // lblDetails
            // 
            this.lblDetails.Location = new System.Drawing.Point(20, 60);
            this.lblDetails.Size = new System.Drawing.Size(80, 20);
            this.lblDetails.Text = "Details:";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(120, 60);
            this.txtDetails.Size = new System.Drawing.Size(200, 40);
            this.txtDetails.Multiline = true;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(20, 110);
            this.lblLocation.Size = new System.Drawing.Size(80, 20);
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(120, 110);
            this.txtLocation.Size = new System.Drawing.Size(200, 20);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(20, 150);
            this.lblStatus.Size = new System.Drawing.Size(80, 20);
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Location = new System.Drawing.Point(120, 150);
            this.cmbStatus.Size = new System.Drawing.Size(200, 20);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] { "Pending", "Confirmed", "Cancelled" });
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(20, 190);
            this.lblType.Size = new System.Drawing.Size(80, 20);
            this.lblType.Text = "Type:";
            // 
            // cmbType
            // 
            this.cmbType.Location = new System.Drawing.Point(120, 190);
            this.cmbType.Size = new System.Drawing.Size(200, 20);
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Items.AddRange(new object[] { "Meeting", "Event", "Other" });
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 230);
            this.btnSave.Size = new System.Drawing.Size(200, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BookingEditForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 280);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnSave);
            this.Name = "BookingEditForm";
            this.Text = "Booking";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
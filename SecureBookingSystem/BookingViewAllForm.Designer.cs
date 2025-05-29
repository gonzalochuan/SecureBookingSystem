namespace SecureBookingSystem
{
    partial class BookingViewAllForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAllBookings;
        private System.Windows.Forms.Button btnSaveList;

        private void InitializeComponent()
        {
            this.dgvAllBookings = new System.Windows.Forms.DataGridView();
            this.btnSaveList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllBookings
            // 
            this.dgvAllBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBookings.Location = new System.Drawing.Point(12, 12);
            this.dgvAllBookings.Name = "dgvAllBookings";
            this.dgvAllBookings.Size = new System.Drawing.Size(600, 350);
            this.dgvAllBookings.ReadOnly = true;
            this.dgvAllBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnSaveList
            // 
            this.btnSaveList.Location = new System.Drawing.Point(12, 370);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(120, 30);
            this.btnSaveList.Text = "Save List";
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // BookingViewAllForm
            // 
            this.ClientSize = new System.Drawing.Size(630, 420);
            this.Controls.Add(this.dgvAllBookings);
            this.Controls.Add(this.btnSaveList);
            this.Name = "BookingViewAllForm";
            this.Text = "View All Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookings)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
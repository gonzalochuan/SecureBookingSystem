namespace SecureBookingSystem
{
    partial class BookingLocationsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvLocations;

        private void InitializeComponent()
        {
            this.dgvLocations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLocations
            // 
            this.dgvLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocations.Location = new System.Drawing.Point(12, 12);
            this.dgvLocations.Name = "dgvLocations";
            this.dgvLocations.Size = new System.Drawing.Size(400, 200);
            // 
            // BookingLocationsForm
            // 
            this.ClientSize = new System.Drawing.Size(430, 230);
            this.Controls.Add(this.dgvLocations);
            this.Name = "BookingLocationsForm";
            this.Text = "Booking Locations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
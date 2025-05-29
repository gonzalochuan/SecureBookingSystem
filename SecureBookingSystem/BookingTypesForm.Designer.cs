namespace SecureBookingSystem
{
    partial class BookingTypesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvTypes;

        private void InitializeComponent()
        {
            this.dgvTypes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTypes
            // 
            this.dgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypes.Location = new System.Drawing.Point(12, 12);
            this.dgvTypes.Name = "dgvTypes";
            this.dgvTypes.Size = new System.Drawing.Size(400, 200);
            // 
            // BookingTypesForm
            // 
            this.ClientSize = new System.Drawing.Size(430, 230);
            this.Controls.Add(this.dgvTypes);
            this.Name = "BookingTypesForm";
            this.Text = "Booking Types";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
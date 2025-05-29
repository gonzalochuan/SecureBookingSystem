namespace SecureBookingSystem
{
    partial class TotalBookingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvSummary;

        private void InitializeComponent()
        {
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(12, 12);
            this.lblTotal.Size = new System.Drawing.Size(400, 23);
            this.lblTotal.Text = "Total Bookings: ";
            // 
            // dgvSummary
            // 
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Location = new System.Drawing.Point(12, 40);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.Size = new System.Drawing.Size(400, 200);
            // 
            // TotalBookingsForm
            // 
            this.ClientSize = new System.Drawing.Size(430, 260);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvSummary);
            this.Name = "TotalBookingsForm";
            this.Text = "Total Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
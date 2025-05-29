namespace SecureBookingSystem
{
    partial class AuditLogForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAudit;

        private void InitializeComponent()
        {
            this.dgvAudit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAudit
            // 
            this.dgvAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudit.Location = new System.Drawing.Point(12, 12);
            this.dgvAudit.Name = "dgvAudit";
            this.dgvAudit.Size = new System.Drawing.Size(500, 300);
            this.dgvAudit.ReadOnly = true;
            this.dgvAudit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // AuditLogForm
            // 
            this.ClientSize = new System.Drawing.Size(530, 330);
            this.Controls.Add(this.dgvAudit);
            this.Name = "AuditLogForm";
            this.Text = "Audit Log";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
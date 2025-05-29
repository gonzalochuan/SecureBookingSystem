namespace SecureBookingSystem
{
    partial class UserEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(20, 20);
            this.lblUsername.Size = new System.Drawing.Size(70, 20);
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(100, 20);
            this.txtUsername.Size = new System.Drawing.Size(150, 20);
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(20, 60);
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 60);
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.PasswordChar = '*';
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(20, 100);
            this.lblRole.Size = new System.Drawing.Size(70, 20);
            this.lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            this.cmbRole.Location = new System.Drawing.Point(100, 100);
            this.cmbRole.Size = new System.Drawing.Size(150, 20);
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] { "admin", "user" });
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 140);
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UserEditForm
            // 
            this.ClientSize = new System.Drawing.Size(280, 190);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnSave);
            this.Name = "UserEditForm";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
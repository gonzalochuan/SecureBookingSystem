using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SecureBookingSystem
{
    public partial class LoginForm : Form
    {
        private int loginAttempts = 0;
        private string captchaCode = "";

        public LoginForm()
        {
            InitializeComponent();
            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {
            var rand = new Random();
            captchaCode = rand.Next(10000, 99999).ToString();
            lblCaptchaImage.Text = captchaCode;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtCaptcha.Text != captchaCode)
            {
                loginAttempts++;
                lblAttempts.Text = $"Attempts: {loginAttempts}/5";
                lblAttempts.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Invalid CAPTCHA.");
                LogAudit(null, "Login Failed");
                if (loginAttempts >= 5)
                {
                    btnLogin.Enabled = false;
                    MessageBox.Show("Too many failed attempts. Login disabled.");
                }
                else
                {
                    GenerateCaptcha();
                }
                return;
            }

            using (var conn = DbHelper.GetConnection())
            {
                var cmd = new MySqlCommand("SELECT id, role FROM users WHERE username=@u AND password=SHA2(@p,256)", conn);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int userId = reader.GetInt32("id");
                        string role = reader.GetString("role");
                        LogAudit(userId, "Login Success");
                        this.Hide();
                        new DashboardForm(userId, role).Show();
                        return;
                    }
                }
            }

            loginAttempts++;
            lblAttempts.Text = $"Attempts: {loginAttempts}/5";
            lblAttempts.ForeColor = System.Drawing.Color.Red;
            LogAudit(null, "Login Failed");

            if (loginAttempts >= 5)
            {
                btnLogin.Enabled = false;
                MessageBox.Show("Too many failed attempts. Login disabled.");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                GenerateCaptcha();
            }
        }

        private void LogAudit(int? userId, string action)
        {
            using (var conn = DbHelper.GetConnection())
            {
                var cmd = new MySqlCommand("INSERT INTO audit_log (user_id, action) VALUES (@uid, @action)", conn);
                cmd.Parameters.AddWithValue("@uid", (object)userId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@action", action);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
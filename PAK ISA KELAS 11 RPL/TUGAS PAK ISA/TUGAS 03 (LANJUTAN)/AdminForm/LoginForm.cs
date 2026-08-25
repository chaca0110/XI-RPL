using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoadLogo();
        }

        private void LoadLogo()
        {
            // Coba muat logo.png dari folder executable, atau dua level ke atas (root repo)
            string[] candidates = new[]
            {
                Path.Combine(Application.StartupPath, "logo.png"),
                Path.Combine(Application.StartupPath, @"..\..\..\..\logo.png"),
                Path.Combine(Application.StartupPath, @"..\..\..\logo.png"),
                Path.Combine(Application.StartupPath, @"..\..\logo.png"),
            };

            foreach (string path in candidates)
            {
                string fullPath = Path.GetFullPath(path);
                if (File.Exists(fullPath))
                {
                    picLogo.Image = Image.FromFile(fullPath);
                    return;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Asumsi login selalu sukses untuk sementara:
            DashboardForm dashboard = new DashboardForm();
            this.Hide();
            dashboard.ShowDialog();
            this.Show();
        }

        private void lnkDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}

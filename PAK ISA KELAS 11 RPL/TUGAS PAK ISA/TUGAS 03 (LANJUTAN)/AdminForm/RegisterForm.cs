using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            LoadLogo();
        }

        private void LoadLogo()
        {
            string[] candidates = new[]
            {
                Path.Combine(Application.StartupPath, "logo.png"),
                Path.Combine(Application.StartupPath, @"..\..\..\..\logo.png"),
                Path.Combine(Application.StartupPath, @"..\..\..\logo.png"),
                Path.Combine(Application.StartupPath, @"..\..\logo.png"),
            };

            foreach (string p in candidates)
            {
                string full = Path.GetFullPath(p);
                if (File.Exists(full))
                {
                    picLogo.Image = Image.FromFile(full);
                    return;
                }
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtNoTelepon.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Tambahkan logika registrasi di sini
            MessageBox.Show("Pendaftaran berhasil!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

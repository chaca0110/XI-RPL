using AdminForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContohSoal1
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void GoToDashboard(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            this.Close();
            dashboard.Show();
        }

        private void GoToBandara(object sender, EventArgs e)
        {
            BandaraForm bandara = new BandaraForm();
            this.Close();
            bandara.Show();
        }

        private void GoToMaskapai(object sender, EventArgs e)
        {
            MasterMaskapaiForm maskapai = new MasterMaskapaiForm();
            this.Close();
            maskapai.Show();
        }

        private void GoToJadwalPenerbangan(object sender, EventArgs e)
        {
            MasterJadwalPenerbanganForm jadwal = new MasterJadwalPenerbanganForm();
            this.Close();
            jadwal.Show();
        }

        private void GoToKodePromo(object sender, EventArgs e)
        {
            MasterKodePromoForm promo = new MasterKodePromoForm();
            this.Close();
            promo.Show();
        }

        private void GoToUbahStatusPenerbangan(object sender, EventArgs e)
        {
            UbahStatusPenerbanganForm status = new UbahStatusPenerbanganForm();
            this.Close();
            status.Show();
        }

        private void Logout(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }
    }
}

using System;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.btnMasterBandara.Click += btnMasterBandara_Click;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        private void btnMasterMaskapai_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenFromDashboard(this, new MasterMaskapaiForm());
        }

        private void btnMasterJadwal_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenFromDashboard(this, new MasterJadwalPenerbanganForm());
        }

        private void btnMasterKodePromo_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenFromDashboard(this, new MasterKodePromoForm());
        }

        private void btnUbahStatus_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenFromDashboard(this, new UbahStatusPenerbanganForm());
        }

        private void btnMasterBandara_Click(object sender, EventArgs e)
        {
            // Sudah berada di layar Master Bandara (Dashboard)
        }
    }
}

using System;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class UbahStatusPenerbanganForm : Form
    {
        public UbahStatusPenerbanganForm()
        {
            InitializeComponent();
        }

        private void btnMasterBandara_Click(object sender, EventArgs e)
        {
            NavigationHelper.BackToDashboard(this);
        }

        private void btnMasterMaskapai_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open(this, new MasterMaskapaiForm());
        }

        private void btnMasterJadwal_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open(this, new MasterJadwalPenerbanganForm());
        }

        private void btnMasterKodePromo_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open(this, new MasterKodePromoForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }
    }
}

using System;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class MasterKodePromoForm : Form
    {
        public MasterKodePromoForm()
        {
            InitializeComponent();
            this.btnUbahStatus.Click += btnUbahStatus_Click;
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

        private void btnUbahStatus_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open(this, new UbahStatusPenerbanganForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }
    }
}

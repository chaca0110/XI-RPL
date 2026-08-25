using System;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class MasterMaskapaiForm : Form
    {
        public MasterMaskapaiForm()
        {
            InitializeComponent();
            this.btnMasterKodePromo.Click += btnMasterKodePromo_Click;
            this.btnUbahStatus.Click += btnUbahStatus_Click;
        }

        private void btnMasterBandara_Click(object sender, EventArgs e)
        {
            NavigationHelper.BackToDashboard(this);
        }

        private void btnMasterJadwal_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open(this, new MasterJadwalPenerbanganForm());
        }

        private void btnMasterKodePromo_Click(object sender, EventArgs e)
        {
            NavigationHelper.Open(this, new MasterKodePromoForm());
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

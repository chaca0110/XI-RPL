using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AdminForm
{
    public partial class TiketSayaForm : Form
    {
        public TiketSayaForm()
        {
            InitializeComponent();
            LoadImages();
            LoadDummyData();
        }

        private void LoadImages()
        {
            string assetDir = Path.Combine(Application.StartupPath, "Assets");
            try 
            {
                picBack.Image = Image.FromFile(Path.Combine(assetDir, "iconAPK.png"));
                
                picBack.SizeMode = PictureBoxSizeMode.Zoom;
                picBack.BorderStyle = BorderStyle.None;
                picBack.BackColor = Color.Transparent;
            } 
            catch { }
        }

        private void LoadDummyData()
        {
            // Adding columns to the DataGridView
            dgvTiket.Columns.Add("KodePenerbangan", "KodePenerbangan");
            dgvTiket.Columns.Add("Maskapai", "Maskapai");
            dgvTiket.Columns.Add("BandaraKeberangkatan", "BandaraKeberangka...");
            dgvTiket.Columns.Add("BandaraTujuan", "BandaraTujuan");
            dgvTiket.Columns.Add("TanggalKeberangkatan", "TanggalKeberangka...");
            dgvTiket.Columns.Add("WaktuPenerbangan", "WaktuPenerbangan");
            dgvTiket.Columns.Add("StatusTerakhir", "StatusTerakhir");

            // Adjust column widths or settings
            dgvTiket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTiket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTiket.AllowUserToAddRows = false;
            dgvTiket.ReadOnly = true;

            // Add dummy data row
            int rowIndex = dgvTiket.Rows.Add("IP-0203", "Pelita Air Service", "Juanda", "Soekarno-Hatta", "22-05-2023", "19:50 - 21:25", "Delay (selama >0...");

            // Select the row to show highlight
            if (dgvTiket.Rows.Count > 0)
            {
                dgvTiket.Rows[rowIndex].Selected = true;
            }
        }
    }
}

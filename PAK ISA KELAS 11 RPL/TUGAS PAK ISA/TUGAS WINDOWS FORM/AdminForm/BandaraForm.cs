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
    public partial class BandaraForm : Form
    {
        BandaraEntities db = new BandaraEntities(); // membuat koneksi ke database
        private int idBandara = -1; // menyimpan id bandara yang sedang diedit (-1 mode tambah, jika > 0 mode update)

        private void BandaraForm_Load(object sender, EventArgs e)
        {
            LoadNegara(); // menampilkan daftar negara ke combobox
            LoadBandara(); // menampilkan semua data bandara ke dalam dataGridView

            dataGridBandara.AutoGenerateColumns = false;
            dataGridBandara.AllowUserToAddRows = false;
            dataGridBandara.ReadOnly = true;
        }

        private void LoadNegara()
        {
            countryBox.DataSource = db.Negaras.OrderBy(n => n.Nama).ToList();
            countryBox.DisplayMember = "Nama";
            countryBox.ValueMember = "ID";
            countryBox.SelectedIndex = -1;
        }

        private void LoadBandara()
        {
            dataGridBandara.DataSource = db.Bandaras.Include("Negara") // Include() mengambil data dari
            .OrderBy(b => b.Nama) // urutkan berdasarkan nama, dari
            .Select(b => new // select() memilih kolom yang akan
            {
                b.ID,
                b.Nama,
                b.KodeIATA,
                b.Kota,
                Negara = b.Negara.Nama,
                b.JumlahTerminal,
                b.Alamat,
            }).ToList();
        }

        private void ResetForm()
        {
            nameTxt.Clear();
            iataTxt.Clear();
            cityTxt.Clear();
            addressTxt.Clear();
            countryBox.SelectedIndex = -1;
            terminalCount.Value = 1;
            idBandara = -1; // kembali ke mode tambah data
            saveBtn.Text = "Simpan";
        }

        public BandaraForm()
        {
            InitializeComponent();
        }

        private void GoToDashboard(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            this.Close();
            dashboard.Show();
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "" || iataTxt.Text == "" || cityTxt.Text == "" || addressTxt.Text == "" || countryBox.SelectedIndex == -1)
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            if (iataTxt.Text.Length != 3)
            {
                MessageBox.Show("Kode IATA wajib memiliki 3 huruf!");
                return;
            }

            if (!iataTxt.Text.All(char.IsLetter)) // All() mengecek semua karakter
            {
                MessageBox.Show("Kode IATA hanya boleh huruf!");
                return;
            }

            bool adaIATA = db.Bandaras.Any(b => b.KodeIATA == iataTxt.Text && b.ID != idBandara);

            if (adaIATA)
            {
                MessageBox.Show("Kode IATA sudah digunakan!");
                return;
            }

            if (terminalCount.Value < 1)
            {
                MessageBox.Show("Jumlah terminal minimal 1");
                return;
            }

            bool adaBandara = db.Bandaras.Any(b => b.Nama.ToLower() == nameTxt.Text.ToLower() && b.ID != idBandara);

            if (adaBandara)
            {
                MessageBox.Show("Nama bandara sudah dipakai!");
                return;
            }

            if (idBandara == -1) // add data
            {
                Bandara bandaraBaru = new Bandara();
                bandaraBaru.Nama = nameTxt.Text;
                bandaraBaru.KodeIATA = iataTxt.Text;
                bandaraBaru.Kota = cityTxt.Text;
                bandaraBaru.NegaraID = Convert.ToInt32(countryBox.SelectedValue);
                bandaraBaru.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                bandaraBaru.Alamat = addressTxt.Text;

                MessageBox.Show("Data berhasil ditambahkan!");
            }
            else // edit
            {
                Bandara editBandara = new Bandara();
                editBandara.Nama = nameTxt.Text;
                editBandara.KodeIATA = iataTxt.Text;
                editBandara.Kota = cityTxt.Text;
                editBandara.NegaraID = Convert.ToInt32(countryBox.SelectedValue);
                editBandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                editBandara.Alamat = addressTxt.Text;

                MessageBox.Show("Data berhasil diedit!");
            }

            Bandara bandara = new Bandara();

            bandara.Nama = nameTxt.Text;
            bandara.KodeIATA = iataTxt.Text;
            bandara.Kota = nameTxt.Text;
            bandara.NegaraID = Convert.ToInt32(countryBox.SelectedValue);
            bandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
            bandara.Alamat = addressTxt.Text;

            db.Bandaras.Add(bandara);
            db.SaveChanges();

            LoadBandara();
            ResetForm();
        }

        private void dataGridBandara_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // error handling agar bukan header yang diklik
            {
                return;
            }

            // edit and delete
            if (dataGridBandara.Columns[e.ColumnIndex].Name == "edit")
            {
                idBandara = Convert.ToInt32(dataGridBandara.Rows[e.RowIndex].Cells["ID"].Value); // mengambil ID pada data
                Bandara bandaraEdit = db.Bandaras.Find(idBandara); // ambil object bandara sesuai dengan ID yang dipilih
                // menampilkan data ke dalam textbox dan combobox
                nameTxt.Text = bandaraEdit.Nama;
                iataTxt.Text = bandaraEdit.KodeIATA;
                cityTxt.Text = bandaraEdit.Kota;
                addressTxt.Text = bandaraEdit.Alamat;

                countryBox.SelectedValue = bandaraEdit.NegaraID;

                terminalCount.Value = bandaraEdit.JumlahTerminal;

                saveBtn.Text = "Update";
            }
            else if (dataGridBandara.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridBandara.Rows[e.RowIndex].Cells["ID"].Value);
                var hasil = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Bandara bandaraHapus = db.Bandaras.Find(id);
                    db.Bandaras.Remove(bandaraHapus);
                    db.Bandaras.Remove(bandaraHapus);
                    db.SaveChanges();

                    LoadBandara();
                    ResetForm();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}

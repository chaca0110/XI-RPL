namespace AdminForm
{
    partial class MasterJadwalPenerbanganForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUbahStatus = new System.Windows.Forms.Button();
            this.btnMasterKodePromo = new System.Windows.Forms.Button();
            this.btnMasterJadwal = new System.Windows.Forms.Button();
            this.btnMasterMaskapai = new System.Windows.Forms.Button();
            this.btnMasterBandara = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.lblKodePenerbangan = new System.Windows.Forms.Label();
            this.txtKodePenerbangan = new System.Windows.Forms.TextBox();
            this.lblDari = new System.Windows.Forms.Label();
            this.cboDari = new System.Windows.Forms.ComboBox();
            this.lblKe = new System.Windows.Forms.Label();
            this.cboKe = new System.Windows.Forms.ComboBox();
            this.lblMaskapai = new System.Windows.Forms.Label();
            this.cboMaskapai = new System.Windows.Forms.ComboBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblWaktuPenerbangan = new System.Windows.Forms.Label();
            this.txtWaktuPenerbangan = new System.Windows.Forms.TextBox();
            this.lblDurasiPenerbangan = new System.Windows.Forms.Label();
            this.txtDurasiPenerbangan = new System.Windows.Forms.TextBox();
            this.lblHargaPertiket = new System.Windows.Forms.Label();
            this.nudHargaPertiket = new System.Windows.Forms.NumericUpDown();
            this.dgvJadwal = new System.Windows.Forms.DataGridView();
            this.lblMasterJadwalSubtitle = new System.Windows.Forms.Label();
            this.lblMasterJadwalTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaPertiket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            this.SuspendLayout();
            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1019, 50);
            this.panelTop.TabIndex = 0;
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(55, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(86, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Dashboard";
            // btnMenu
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(10, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "";
            this.btnMenu.UseVisualStyleBackColor = true;
            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnUbahStatus);
            this.panelSidebar.Controls.Add(this.btnMasterKodePromo);
            this.panelSidebar.Controls.Add(this.btnMasterJadwal);
            this.panelSidebar.Controls.Add(this.btnMasterMaskapai);
            this.panelSidebar.Controls.Add(this.btnMasterBandara);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 50);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 474);
            this.panelSidebar.TabIndex = 1;
            // btnLogout
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 427);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(248, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // btnUbahStatus
            this.btnUbahStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUbahStatus.FlatAppearance.BorderSize = 0;
            this.btnUbahStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbahStatus.ForeColor = System.Drawing.Color.DimGray;
            this.btnUbahStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUbahStatus.Location = new System.Drawing.Point(0, 180);
            this.btnUbahStatus.Name = "btnUbahStatus";
            this.btnUbahStatus.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUbahStatus.Size = new System.Drawing.Size(248, 45);
            this.btnUbahStatus.TabIndex = 4;
            this.btnUbahStatus.Text = "  Ubah Status Penerbangan";
            this.btnUbahStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUbahStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUbahStatus.UseVisualStyleBackColor = true;
            // btnMasterKodePromo
            this.btnMasterKodePromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterKodePromo.FlatAppearance.BorderSize = 0;
            this.btnMasterKodePromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterKodePromo.ForeColor = System.Drawing.Color.DimGray;
            this.btnMasterKodePromo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterKodePromo.Location = new System.Drawing.Point(0, 135);
            this.btnMasterKodePromo.Name = "btnMasterKodePromo";
            this.btnMasterKodePromo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMasterKodePromo.Size = new System.Drawing.Size(248, 45);
            this.btnMasterKodePromo.TabIndex = 3;
            this.btnMasterKodePromo.Text = "  Master Kode Promo";
            this.btnMasterKodePromo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterKodePromo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasterKodePromo.UseVisualStyleBackColor = true;
            // btnMasterJadwal
            this.btnMasterJadwal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterJadwal.FlatAppearance.BorderSize = 0;
            this.btnMasterJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterJadwal.ForeColor = System.Drawing.Color.Black;
            this.btnMasterJadwal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterJadwal.Location = new System.Drawing.Point(0, 90);
            this.btnMasterJadwal.Name = "btnMasterJadwal";
            this.btnMasterJadwal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMasterJadwal.Size = new System.Drawing.Size(248, 45);
            this.btnMasterJadwal.TabIndex = 2;
            this.btnMasterJadwal.Text = "  Master Jadwal Penerbangan";
            this.btnMasterJadwal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterJadwal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasterJadwal.UseVisualStyleBackColor = true;
            // btnMasterMaskapai
            this.btnMasterMaskapai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterMaskapai.FlatAppearance.BorderSize = 0;
            this.btnMasterMaskapai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterMaskapai.ForeColor = System.Drawing.Color.DimGray;
            this.btnMasterMaskapai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterMaskapai.Location = new System.Drawing.Point(0, 45);
            this.btnMasterMaskapai.Name = "btnMasterMaskapai";
            this.btnMasterMaskapai.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMasterMaskapai.Size = new System.Drawing.Size(248, 45);
            this.btnMasterMaskapai.TabIndex = 1;
            this.btnMasterMaskapai.Text = "  Master Maskapai";
            this.btnMasterMaskapai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterMaskapai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasterMaskapai.UseVisualStyleBackColor = true;
            this.btnMasterMaskapai.Click += new System.EventHandler(this.btnMasterMaskapai_Click);
            // btnMasterBandara
            this.btnMasterBandara.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterBandara.FlatAppearance.BorderSize = 0;
            this.btnMasterBandara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterBandara.ForeColor = System.Drawing.Color.DimGray;
            this.btnMasterBandara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterBandara.Location = new System.Drawing.Point(0, 0);
            this.btnMasterBandara.Name = "btnMasterBandara";
            this.btnMasterBandara.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMasterBandara.Size = new System.Drawing.Size(248, 45);
            this.btnMasterBandara.TabIndex = 0;
            this.btnMasterBandara.Text = "  Master Bandara";
            this.btnMasterBandara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterBandara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasterBandara.UseVisualStyleBackColor = true;
            this.btnMasterBandara.Click += new System.EventHandler(this.btnMasterBandara_Click);
            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.btnSimpan);
            this.panelContent.Controls.Add(this.btnBatal);
            this.panelContent.Controls.Add(this.txtKodePenerbangan);
            this.panelContent.Controls.Add(this.lblKodePenerbangan);
            this.panelContent.Controls.Add(this.cboDari);
            this.panelContent.Controls.Add(this.lblDari);
            this.panelContent.Controls.Add(this.cboKe);
            this.panelContent.Controls.Add(this.lblKe);
            this.panelContent.Controls.Add(this.cboMaskapai);
            this.panelContent.Controls.Add(this.lblMaskapai);
            this.panelContent.Controls.Add(this.dtpTanggal);
            this.panelContent.Controls.Add(this.lblTanggal);
            this.panelContent.Controls.Add(this.txtWaktuPenerbangan);
            this.panelContent.Controls.Add(this.lblWaktuPenerbangan);
            this.panelContent.Controls.Add(this.txtDurasiPenerbangan);
            this.panelContent.Controls.Add(this.lblDurasiPenerbangan);
            this.panelContent.Controls.Add(this.nudHargaPertiket);
            this.panelContent.Controls.Add(this.lblHargaPertiket);
            this.panelContent.Controls.Add(this.dgvJadwal);
            this.panelContent.Controls.Add(this.lblMasterJadwalSubtitle);
            this.panelContent.Controls.Add(this.lblMasterJadwalTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(769, 560);
            this.panelContent.TabIndex = 2;
            // btnSimpan
            this.btnSimpan.Location = new System.Drawing.Point(570, 480);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // btnBatal
            this.btnBatal.Location = new System.Drawing.Point(460, 480);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(90, 30);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            
            // lblKodePenerbangan
            this.lblKodePenerbangan.AutoSize = true;
            this.lblKodePenerbangan.Location = new System.Drawing.Point(20, 330);
            this.lblKodePenerbangan.Name = "lblKodePenerbangan";
            this.lblKodePenerbangan.Size = new System.Drawing.Size(107, 15);
            this.lblKodePenerbangan.Text = "Kode Penerbangan";
            // txtKodePenerbangan
            this.txtKodePenerbangan.Location = new System.Drawing.Point(140, 327);
            this.txtKodePenerbangan.Name = "txtKodePenerbangan";
            this.txtKodePenerbangan.Size = new System.Drawing.Size(200, 23);
            
            // lblDari
            this.lblDari.AutoSize = true;
            this.lblDari.Location = new System.Drawing.Point(20, 360);
            this.lblDari.Name = "lblDari";
            this.lblDari.Size = new System.Drawing.Size(28, 15);
            this.lblDari.Text = "Dari";
            // cboDari
            this.cboDari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDari.Location = new System.Drawing.Point(140, 357);
            this.cboDari.Name = "cboDari";
            this.cboDari.Size = new System.Drawing.Size(200, 23);
            
            // lblKe
            this.lblKe.AutoSize = true;
            this.lblKe.Location = new System.Drawing.Point(20, 390);
            this.lblKe.Name = "lblKe";
            this.lblKe.Size = new System.Drawing.Size(20, 15);
            this.lblKe.Text = "Ke";
            // cboKe
            this.cboKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKe.Location = new System.Drawing.Point(140, 387);
            this.cboKe.Name = "cboKe";
            this.cboKe.Size = new System.Drawing.Size(200, 23);
            
            // lblMaskapai
            this.lblMaskapai.AutoSize = true;
            this.lblMaskapai.Location = new System.Drawing.Point(20, 420);
            this.lblMaskapai.Name = "lblMaskapai";
            this.lblMaskapai.Size = new System.Drawing.Size(57, 15);
            this.lblMaskapai.Text = "Maskapai";
            // cboMaskapai
            this.cboMaskapai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaskapai.Location = new System.Drawing.Point(140, 417);
            this.cboMaskapai.Name = "cboMaskapai";
            this.cboMaskapai.Size = new System.Drawing.Size(200, 23);
            
            // lblTanggal
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(380, 330);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(48, 15);
            this.lblTanggal.Text = "Tanggal";
            // dtpTanggal
            this.dtpTanggal.Location = new System.Drawing.Point(520, 327);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(200, 23);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.CustomFormat = "dddd, dd MMMM yyyy";
            
            // lblWaktuPenerbangan
            this.lblWaktuPenerbangan.AutoSize = true;
            this.lblWaktuPenerbangan.Location = new System.Drawing.Point(380, 360);
            this.lblWaktuPenerbangan.Name = "lblWaktuPenerbangan";
            this.lblWaktuPenerbangan.Size = new System.Drawing.Size(113, 15);
            this.lblWaktuPenerbangan.Text = "Waktu Penerbangan";
            // txtWaktuPenerbangan
            this.txtWaktuPenerbangan.Location = new System.Drawing.Point(520, 357);
            this.txtWaktuPenerbangan.Name = "txtWaktuPenerbangan";
            this.txtWaktuPenerbangan.Size = new System.Drawing.Size(200, 23);
            this.txtWaktuPenerbangan.Text = "00:00";
            
            // lblDurasiPenerbangan
            this.lblDurasiPenerbangan.AutoSize = true;
            this.lblDurasiPenerbangan.Location = new System.Drawing.Point(380, 390);
            this.lblDurasiPenerbangan.Name = "lblDurasiPenerbangan";
            this.lblDurasiPenerbangan.Size = new System.Drawing.Size(113, 15);
            this.lblDurasiPenerbangan.Text = "Durasi Penerbangan";
            // txtDurasiPenerbangan
            this.txtDurasiPenerbangan.Location = new System.Drawing.Point(520, 387);
            this.txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            this.txtDurasiPenerbangan.Size = new System.Drawing.Size(200, 23);
            
            // lblHargaPertiket
            this.lblHargaPertiket.AutoSize = true;
            this.lblHargaPertiket.Location = new System.Drawing.Point(380, 420);
            this.lblHargaPertiket.Name = "lblHargaPertiket";
            this.lblHargaPertiket.Size = new System.Drawing.Size(89, 15);
            this.lblHargaPertiket.Text = "Harga per Tiket";
            // nudHargaPertiket
            this.nudHargaPertiket.Location = new System.Drawing.Point(520, 417);
            this.nudHargaPertiket.Name = "nudHargaPertiket";
            this.nudHargaPertiket.Size = new System.Drawing.Size(200, 23);
            this.nudHargaPertiket.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            
            // dgvJadwal
            this.dgvJadwal.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwal.Location = new System.Drawing.Point(20, 80);
            this.dgvJadwal.Name = "dgvJadwal";
            this.dgvJadwal.Size = new System.Drawing.Size(700, 220);
            this.dgvJadwal.TabIndex = 2;
            // lblMasterJadwalSubtitle
            this.lblMasterJadwalSubtitle.AutoSize = true;
            this.lblMasterJadwalSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMasterJadwalSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblMasterJadwalSubtitle.Location = new System.Drawing.Point(20, 50);
            this.lblMasterJadwalSubtitle.Name = "lblMasterJadwalSubtitle";
            this.lblMasterJadwalSubtitle.Size = new System.Drawing.Size(326, 15);
            this.lblMasterJadwalSubtitle.TabIndex = 1;
            this.lblMasterJadwalSubtitle.Text = "Semua jadwal penerbangan yang terdaftar akan muncul di sini";
            // lblMasterJadwalTitle
            this.lblMasterJadwalTitle.AutoSize = true;
            this.lblMasterJadwalTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMasterJadwalTitle.Location = new System.Drawing.Point(20, 20);
            this.lblMasterJadwalTitle.Name = "lblMasterJadwalTitle";
            this.lblMasterJadwalTitle.Size = new System.Drawing.Size(262, 25);
            this.lblMasterJadwalTitle.TabIndex = 0;
            this.lblMasterJadwalTitle.Text = "Master Jadwal Penerbangan";
            // MasterJadwalPenerbanganForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 560);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MasterJadwalPenerbanganForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Admin";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaPertiket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUbahStatus;
        private System.Windows.Forms.Button btnMasterKodePromo;
        private System.Windows.Forms.Button btnMasterJadwal;
        private System.Windows.Forms.Button btnMasterMaskapai;
        private System.Windows.Forms.Button btnMasterBandara;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        
        private System.Windows.Forms.Label lblKodePenerbangan;
        private System.Windows.Forms.TextBox txtKodePenerbangan;
        private System.Windows.Forms.Label lblDari;
        private System.Windows.Forms.ComboBox cboDari;
        private System.Windows.Forms.Label lblKe;
        private System.Windows.Forms.ComboBox cboKe;
        private System.Windows.Forms.Label lblMaskapai;
        private System.Windows.Forms.ComboBox cboMaskapai;
        
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label lblWaktuPenerbangan;
        private System.Windows.Forms.TextBox txtWaktuPenerbangan;
        private System.Windows.Forms.Label lblDurasiPenerbangan;
        private System.Windows.Forms.TextBox txtDurasiPenerbangan;
        private System.Windows.Forms.Label lblHargaPertiket;
        private System.Windows.Forms.NumericUpDown nudHargaPertiket;
        
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.Label lblMasterJadwalSubtitle;
        private System.Windows.Forms.Label lblMasterJadwalTitle;
    }
}


namespace AdminForm
{
    partial class MasterMaskapaiForm
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
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.numJumlahKru = new System.Windows.Forms.NumericUpDown();
            this.lblJumlahKru = new System.Windows.Forms.Label();
            this.txtPerusahaan = new System.Windows.Forms.TextBox();
            this.lblPerusahaan = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.dgvMaskapai = new System.Windows.Forms.DataGridView();
            this.lblMasterMaskapaiSubtitle = new System.Windows.Forms.Label();
            this.lblMasterMaskapaiTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahKru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaskapai)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1019, 50);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(55, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(86, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Dashboard";
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(10, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "≡";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // panelSidebar
            // 
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
            // 
            // btnLogout
            // 
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
            // 
            // btnUbahStatus
            // 
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
            // 
            // btnMasterKodePromo
            // 
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
            // 
            // btnMasterJadwal
            // 
            this.btnMasterJadwal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterJadwal.FlatAppearance.BorderSize = 0;
            this.btnMasterJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterJadwal.ForeColor = System.Drawing.Color.DimGray;
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
            this.btnMasterJadwal.Click += new System.EventHandler(this.btnMasterJadwal_Click);
            // 
            // btnMasterMaskapai
            // 
            this.btnMasterMaskapai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterMaskapai.FlatAppearance.BorderSize = 0;
            this.btnMasterMaskapai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterMaskapai.ForeColor = System.Drawing.Color.Black;
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
            // 
            // btnMasterBandara
            // 
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
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.btnSimpan);
            this.panelContent.Controls.Add(this.btnBatal);
            this.panelContent.Controls.Add(this.txtAlamat);
            this.panelContent.Controls.Add(this.lblAlamat);
            this.panelContent.Controls.Add(this.numJumlahKru);
            this.panelContent.Controls.Add(this.lblJumlahKru);
            this.panelContent.Controls.Add(this.txtPerusahaan);
            this.panelContent.Controls.Add(this.lblPerusahaan);
            this.panelContent.Controls.Add(this.txtNama);
            this.panelContent.Controls.Add(this.lblNama);
            this.panelContent.Controls.Add(this.dgvMaskapai);
            this.panelContent.Controls.Add(this.lblMasterMaskapaiSubtitle);
            this.panelContent.Controls.Add(this.lblMasterMaskapaiTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(769, 474);
            this.panelContent.TabIndex = 2;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(570, 420);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(460, 420);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(90, 30);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(460, 327);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(200, 80);
            this.txtAlamat.TabIndex = 14;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(350, 330);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(45, 15);
            this.lblAlamat.TabIndex = 13;
            this.lblAlamat.Text = "Alamat";
            // 
            // numJumlahKru
            // 
            this.numJumlahKru.Location = new System.Drawing.Point(100, 357);
            this.numJumlahKru.Name = "numJumlahKru";
            this.numJumlahKru.Size = new System.Drawing.Size(200, 23);
            this.numJumlahKru.TabIndex = 12;
            // 
            // lblJumlahKru
            // 
            this.lblJumlahKru.AutoSize = true;
            this.lblJumlahKru.Location = new System.Drawing.Point(20, 360);
            this.lblJumlahKru.Name = "lblJumlahKru";
            this.lblJumlahKru.Size = new System.Drawing.Size(67, 15);
            this.lblJumlahKru.TabIndex = 11;
            this.lblJumlahKru.Text = "Jumlah Kru";
            // 
            // txtPerusahaan
            // 
            this.txtPerusahaan.Location = new System.Drawing.Point(100, 327);
            this.txtPerusahaan.Name = "txtPerusahaan";
            this.txtPerusahaan.Size = new System.Drawing.Size(200, 23);
            this.txtPerusahaan.TabIndex = 6;
            // 
            // lblPerusahaan
            // 
            this.lblPerusahaan.AutoSize = true;
            this.lblPerusahaan.Location = new System.Drawing.Point(20, 330);
            this.lblPerusahaan.Name = "lblPerusahaan";
            this.lblPerusahaan.Size = new System.Drawing.Size(68, 15);
            this.lblPerusahaan.TabIndex = 5;
            this.lblPerusahaan.Text = "Perusahaan";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(100, 297);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 23);
            this.txtNama.TabIndex = 4;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(20, 300);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(39, 15);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Nama";
            // 
            // dgvMaskapai
            // 
            this.dgvMaskapai.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvMaskapai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaskapai.Location = new System.Drawing.Point(20, 80);
            this.dgvMaskapai.Name = "dgvMaskapai";
            this.dgvMaskapai.Size = new System.Drawing.Size(700, 200);
            this.dgvMaskapai.TabIndex = 2;
            // 
            // lblMasterMaskapaiSubtitle
            // 
            this.lblMasterMaskapaiSubtitle.AutoSize = true;
            this.lblMasterMaskapaiSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMasterMaskapaiSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblMasterMaskapaiSubtitle.Location = new System.Drawing.Point(20, 50);
            this.lblMasterMaskapaiSubtitle.Name = "lblMasterMaskapaiSubtitle";
            this.lblMasterMaskapaiSubtitle.Size = new System.Drawing.Size(277, 15);
            this.lblMasterMaskapaiSubtitle.TabIndex = 1;
            this.lblMasterMaskapaiSubtitle.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            // 
            // lblMasterMaskapaiTitle
            // 
            this.lblMasterMaskapaiTitle.AutoSize = true;
            this.lblMasterMaskapaiTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMasterMaskapaiTitle.Location = new System.Drawing.Point(20, 20);
            this.lblMasterMaskapaiTitle.Name = "lblMasterMaskapaiTitle";
            this.lblMasterMaskapaiTitle.Size = new System.Drawing.Size(161, 25);
            this.lblMasterMaskapaiTitle.TabIndex = 0;
            this.lblMasterMaskapaiTitle.Text = "Master Maskapai";
            // 
            // MasterMaskapaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 524);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MasterMaskapaiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Admin";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahKru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaskapai)).EndInit();
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
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.NumericUpDown numJumlahKru;
        private System.Windows.Forms.Label lblJumlahKru;
        private System.Windows.Forms.TextBox txtPerusahaan;
        private System.Windows.Forms.Label lblPerusahaan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.DataGridView dgvMaskapai;
        private System.Windows.Forms.Label lblMasterMaskapaiSubtitle;
        private System.Windows.Forms.Label lblMasterMaskapaiTitle;
    }
}


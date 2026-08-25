namespace AdminForm
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.numJumlahTerminal = new System.Windows.Forms.NumericUpDown();
            this.lblJumlahTerminal = new System.Windows.Forms.Label();
            this.cmbNegara = new System.Windows.Forms.ComboBox();
            this.lblNegara = new System.Windows.Forms.Label();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.lblKota = new System.Windows.Forms.Label();
            this.txtKodeIata = new System.Windows.Forms.TextBox();
            this.lblKodeIata = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.dgvBandara = new System.Windows.Forms.DataGridView();
            this.lblMasterBandaraSubtitle = new System.Windows.Forms.Label();
            this.lblMasterBandaraTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandara)).BeginInit();
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
            this.btnUbahStatus.Click += new System.EventHandler(this.btnUbahStatus_Click);
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
            this.btnMasterKodePromo.Click += new System.EventHandler(this.btnMasterKodePromo_Click);
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
            // 
            // btnMasterBandara
            // 
            this.btnMasterBandara.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterBandara.FlatAppearance.BorderSize = 0;
            this.btnMasterBandara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterBandara.ForeColor = System.Drawing.Color.Black;
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
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.btnSimpan);
            this.panelContent.Controls.Add(this.btnBatal);
            this.panelContent.Controls.Add(this.txtAlamat);
            this.panelContent.Controls.Add(this.lblAlamat);
            this.panelContent.Controls.Add(this.numJumlahTerminal);
            this.panelContent.Controls.Add(this.lblJumlahTerminal);
            this.panelContent.Controls.Add(this.cmbNegara);
            this.panelContent.Controls.Add(this.lblNegara);
            this.panelContent.Controls.Add(this.txtKota);
            this.panelContent.Controls.Add(this.lblKota);
            this.panelContent.Controls.Add(this.txtKodeIata);
            this.panelContent.Controls.Add(this.lblKodeIata);
            this.panelContent.Controls.Add(this.txtNama);
            this.panelContent.Controls.Add(this.lblNama);
            this.panelContent.Controls.Add(this.dgvBandara);
            this.panelContent.Controls.Add(this.lblMasterBandaraSubtitle);
            this.panelContent.Controls.Add(this.lblMasterBandaraTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(769, 474);
            this.panelContent.TabIndex = 2;
            // btnSimpan
            this.btnSimpan.Location = new System.Drawing.Point(570, 420);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // btnBatal
            this.btnBatal.Location = new System.Drawing.Point(460, 420);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(90, 30);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // txtAlamat
            this.txtAlamat.Location = new System.Drawing.Point(460, 327);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(200, 80);
            this.txtAlamat.TabIndex = 14;
            // lblAlamat
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(350, 330);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(45, 15);
            this.lblAlamat.TabIndex = 13;
            this.lblAlamat.Text = "Alamat";
            // numJumlahTerminal
            this.numJumlahTerminal.Location = new System.Drawing.Point(460, 297);
            this.numJumlahTerminal.Name = "numJumlahTerminal";
            this.numJumlahTerminal.Size = new System.Drawing.Size(200, 23);
            this.numJumlahTerminal.TabIndex = 12;
            // lblJumlahTerminal
            this.lblJumlahTerminal.AutoSize = true;
            this.lblJumlahTerminal.Location = new System.Drawing.Point(350, 300);
            this.lblJumlahTerminal.Name = "lblJumlahTerminal";
            this.lblJumlahTerminal.Size = new System.Drawing.Size(94, 15);
            this.lblJumlahTerminal.TabIndex = 11;
            this.lblJumlahTerminal.Text = "Jumlah Terminal";


            // cmbNegara
            // 
            this.cmbNegara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegara.FormattingEnabled = true;
            this.cmbNegara.Location = new System.Drawing.Point(100, 387);
            this.cmbNegara.Name = "cmbNegara";
            this.cmbNegara.Size = new System.Drawing.Size(200, 23);
            this.cmbNegara.TabIndex = 10;
            // 
            // lblNegara
            // 
            this.lblNegara.AutoSize = true;
            this.lblNegara.Location = new System.Drawing.Point(20, 390);
            this.lblNegara.Name = "lblNegara";
            this.lblNegara.Size = new System.Drawing.Size(45, 15);
            this.lblNegara.TabIndex = 9;
            this.lblNegara.Text = "Negara";
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(100, 357);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(200, 23);
            this.txtKota.TabIndex = 8;
            // 
            // lblKota
            // 
            this.lblKota.AutoSize = true;
            this.lblKota.Location = new System.Drawing.Point(20, 360);
            this.lblKota.Name = "lblKota";
            this.lblKota.Size = new System.Drawing.Size(31, 15);
            this.lblKota.TabIndex = 7;
            this.lblKota.Text = "Kota";
            // 
            // txtKodeIata
            // 
            this.txtKodeIata.Location = new System.Drawing.Point(100, 327);
            this.txtKodeIata.Name = "txtKodeIata";
            this.txtKodeIata.Size = new System.Drawing.Size(200, 23);
            this.txtKodeIata.TabIndex = 6;
            // 
            // lblKodeIata
            // 
            this.lblKodeIata.AutoSize = true;
            this.lblKodeIata.Location = new System.Drawing.Point(20, 330);
            this.lblKodeIata.Name = "lblKodeIata";
            this.lblKodeIata.Size = new System.Drawing.Size(61, 15);
            this.lblKodeIata.TabIndex = 5;
            this.lblKodeIata.Text = "Kode IATA";
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
            // dgvBandara
            // 
            this.dgvBandara.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvBandara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBandara.Location = new System.Drawing.Point(20, 80);
            this.dgvBandara.Name = "dgvBandara";
            this.dgvBandara.Size = new System.Drawing.Size(700, 200);
            this.dgvBandara.TabIndex = 2;
            // 
            // lblMasterBandaraSubtitle
            // 
            this.lblMasterBandaraSubtitle.AutoSize = true;
            this.lblMasterBandaraSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMasterBandaraSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblMasterBandaraSubtitle.Location = new System.Drawing.Point(20, 50);
            this.lblMasterBandaraSubtitle.Name = "lblMasterBandaraSubtitle";
            this.lblMasterBandaraSubtitle.Size = new System.Drawing.Size(272, 15);
            this.lblMasterBandaraSubtitle.TabIndex = 1;
            this.lblMasterBandaraSubtitle.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // lblMasterBandaraTitle
            // 
            this.lblMasterBandaraTitle.AutoSize = true;
            this.lblMasterBandaraTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMasterBandaraTitle.Location = new System.Drawing.Point(20, 20);
            this.lblMasterBandaraTitle.Name = "lblMasterBandaraTitle";
            this.lblMasterBandaraTitle.Size = new System.Drawing.Size(152, 25);
            this.lblMasterBandaraTitle.TabIndex = 0;
            this.lblMasterBandaraTitle.Text = "Master Bandara";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 524);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Admin";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnMasterBandara;
        private System.Windows.Forms.Button btnMasterMaskapai;
        private System.Windows.Forms.Button btnMasterJadwal;
        private System.Windows.Forms.Button btnMasterKodePromo;
        private System.Windows.Forms.Button btnUbahStatus;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblMasterBandaraTitle;
        private System.Windows.Forms.Label lblMasterBandaraSubtitle;
        private System.Windows.Forms.DataGridView dgvBandara;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblKodeIata;
        private System.Windows.Forms.TextBox txtKodeIata;
        private System.Windows.Forms.Label lblKota;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.Label lblNegara;
        private System.Windows.Forms.ComboBox cmbNegara;
        private System.Windows.Forms.Label lblJumlahTerminal;
        private System.Windows.Forms.NumericUpDown numJumlahTerminal;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
    }
}


namespace AdminForm
{
    partial class MasterKodePromoForm
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
            this.lblKodePromo = new System.Windows.Forms.Label();
            this.txtKodePromo = new System.Windows.Forms.TextBox();
            this.lblBerlakuSampai = new System.Windows.Forms.Label();
            this.dtpBerlakuSampai = new System.Windows.Forms.DateTimePicker();
            this.lblPersentaseDiskon = new System.Windows.Forms.Label();
            this.nudPersentaseDiskon = new System.Windows.Forms.NumericUpDown();
            this.lblMaksimumDiskon = new System.Windows.Forms.Label();
            this.nudMaksimumDiskon = new System.Windows.Forms.NumericUpDown();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.dgvKodePromo = new System.Windows.Forms.DataGridView();
            this.lblMasterKodePromoSubtitle = new System.Windows.Forms.Label();
            this.lblMasterKodePromoTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersentaseDiskon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaksimumDiskon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKodePromo)).BeginInit();
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
            this.btnMasterKodePromo.ForeColor = System.Drawing.Color.Black;
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
            this.panelContent.Controls.Add(this.txtDeskripsi);
            this.panelContent.Controls.Add(this.lblDeskripsi);
            this.panelContent.Controls.Add(this.nudMaksimumDiskon);
            this.panelContent.Controls.Add(this.lblMaksimumDiskon);
            this.panelContent.Controls.Add(this.nudPersentaseDiskon);
            this.panelContent.Controls.Add(this.lblPersentaseDiskon);
            this.panelContent.Controls.Add(this.dtpBerlakuSampai);
            this.panelContent.Controls.Add(this.lblBerlakuSampai);
            this.panelContent.Controls.Add(this.txtKodePromo);
            this.panelContent.Controls.Add(this.lblKodePromo);
            this.panelContent.Controls.Add(this.dgvKodePromo);
            this.panelContent.Controls.Add(this.lblMasterKodePromoSubtitle);
            this.panelContent.Controls.Add(this.lblMasterKodePromoTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(769, 524);
            this.panelContent.TabIndex = 2;
            // btnSimpan
            this.btnSimpan.Location = new System.Drawing.Point(635, 450);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // btnBatal
            this.btnBatal.Location = new System.Drawing.Point(525, 450);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(90, 30);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // lblKodePromo
            this.lblKodePromo.AutoSize = true;
            this.lblKodePromo.Location = new System.Drawing.Point(20, 310);
            this.lblKodePromo.Name = "lblKodePromo";
            this.lblKodePromo.Size = new System.Drawing.Size(72, 15);
            this.lblKodePromo.Text = "Kode Promo";
            // txtKodePromo
            this.txtKodePromo.Location = new System.Drawing.Point(150, 307);
            this.txtKodePromo.Name = "txtKodePromo";
            this.txtKodePromo.Size = new System.Drawing.Size(220, 23);
            // lblBerlakuSampai
            this.lblBerlakuSampai.AutoSize = true;
            this.lblBerlakuSampai.Location = new System.Drawing.Point(20, 340);
            this.lblBerlakuSampai.Name = "lblBerlakuSampai";
            this.lblBerlakuSampai.Size = new System.Drawing.Size(88, 15);
            this.lblBerlakuSampai.Text = "Berlaku Sampai";
            // dtpBerlakuSampai
            this.dtpBerlakuSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBerlakuSampai.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpBerlakuSampai.Location = new System.Drawing.Point(150, 337);
            this.dtpBerlakuSampai.Name = "dtpBerlakuSampai";
            this.dtpBerlakuSampai.Size = new System.Drawing.Size(220, 23);
            // lblPersentaseDiskon
            this.lblPersentaseDiskon.AutoSize = true;
            this.lblPersentaseDiskon.Location = new System.Drawing.Point(20, 370);
            this.lblPersentaseDiskon.Name = "lblPersentaseDiskon";
            this.lblPersentaseDiskon.Size = new System.Drawing.Size(107, 15);
            this.lblPersentaseDiskon.Text = "Persentase Diskon";
            // nudPersentaseDiskon
            this.nudPersentaseDiskon.Location = new System.Drawing.Point(150, 367);
            this.nudPersentaseDiskon.Name = "nudPersentaseDiskon";
            this.nudPersentaseDiskon.Size = new System.Drawing.Size(220, 23);
            this.nudPersentaseDiskon.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            // lblMaksimumDiskon
            this.lblMaksimumDiskon.AutoSize = true;
            this.lblMaksimumDiskon.Location = new System.Drawing.Point(20, 400);
            this.lblMaksimumDiskon.Name = "lblMaksimumDiskon";
            this.lblMaksimumDiskon.Size = new System.Drawing.Size(99, 15);
            this.lblMaksimumDiskon.Text = "Maksimum Diskon";
            // nudMaksimumDiskon
            this.nudMaksimumDiskon.Location = new System.Drawing.Point(150, 397);
            this.nudMaksimumDiskon.Name = "nudMaksimumDiskon";
            this.nudMaksimumDiskon.Size = new System.Drawing.Size(220, 23);
            this.nudMaksimumDiskon.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // lblDeskripsi
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(410, 310);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(50, 15);
            this.lblDeskripsi.Text = "Deskripsi";
            // txtDeskripsi
            this.txtDeskripsi.Location = new System.Drawing.Point(410, 330);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(315, 110);
            // dgvKodePromo
            this.dgvKodePromo.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvKodePromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKodePromo.Location = new System.Drawing.Point(20, 80);
            this.dgvKodePromo.Name = "dgvKodePromo";
            this.dgvKodePromo.Size = new System.Drawing.Size(700, 200);
            this.dgvKodePromo.TabIndex = 2;
            // lblMasterKodePromoSubtitle
            this.lblMasterKodePromoSubtitle.AutoSize = true;
            this.lblMasterKodePromoSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMasterKodePromoSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblMasterKodePromoSubtitle.Location = new System.Drawing.Point(20, 50);
            this.lblMasterKodePromoSubtitle.Name = "lblMasterKodePromoSubtitle";
            this.lblMasterKodePromoSubtitle.Size = new System.Drawing.Size(288, 15);
            this.lblMasterKodePromoSubtitle.TabIndex = 1;
            this.lblMasterKodePromoSubtitle.Text = "Semua kode promo yang terdaftar muncul di sini";
            // lblMasterKodePromoTitle
            this.lblMasterKodePromoTitle.AutoSize = true;
            this.lblMasterKodePromoTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMasterKodePromoTitle.Location = new System.Drawing.Point(20, 20);
            this.lblMasterKodePromoTitle.Name = "lblMasterKodePromoTitle";
            this.lblMasterKodePromoTitle.Size = new System.Drawing.Size(195, 25);
            this.lblMasterKodePromoTitle.TabIndex = 0;
            this.lblMasterKodePromoTitle.Text = "Master Kode Promo";
            // MasterKodePromoForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 524);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MasterKodePromoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Admin";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersentaseDiskon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaksimumDiskon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKodePromo)).EndInit();
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
        private System.Windows.Forms.Label lblKodePromo;
        private System.Windows.Forms.TextBox txtKodePromo;
        private System.Windows.Forms.Label lblBerlakuSampai;
        private System.Windows.Forms.DateTimePicker dtpBerlakuSampai;
        private System.Windows.Forms.Label lblPersentaseDiskon;
        private System.Windows.Forms.NumericUpDown nudPersentaseDiskon;
        private System.Windows.Forms.Label lblMaksimumDiskon;
        private System.Windows.Forms.NumericUpDown nudMaksimumDiskon;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.DataGridView dgvKodePromo;
        private System.Windows.Forms.Label lblMasterKodePromoSubtitle;
        private System.Windows.Forms.Label lblMasterKodePromoTitle;
    }
}


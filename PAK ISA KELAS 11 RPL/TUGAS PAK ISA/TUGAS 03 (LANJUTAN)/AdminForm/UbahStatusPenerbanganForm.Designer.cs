namespace AdminForm
{
    partial class UbahStatusPenerbanganForm
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
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.lblUbahStatusSubtitle = new System.Windows.Forms.Label();
            this.lblUbahStatusTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
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
            this.btnUbahStatus.ForeColor = System.Drawing.Color.Black;
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
            this.btnMasterKodePromo.Click += new System.EventHandler(this.btnMasterKodePromo_Click);
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
            this.panelContent.Controls.Add(this.dgvStatus);
            this.panelContent.Controls.Add(this.lblUbahStatusSubtitle);
            this.panelContent.Controls.Add(this.lblUbahStatusTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(769, 474);
            this.panelContent.TabIndex = 2;
            // dgvStatus
            this.dgvStatus.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Location = new System.Drawing.Point(20, 80);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.Size = new System.Drawing.Size(700, 350);
            this.dgvStatus.TabIndex = 2;
            // lblUbahStatusSubtitle
            this.lblUbahStatusSubtitle.AutoSize = true;
            this.lblUbahStatusSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUbahStatusSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblUbahStatusSubtitle.Location = new System.Drawing.Point(20, 50);
            this.lblUbahStatusSubtitle.Name = "lblUbahStatusSubtitle";
            this.lblUbahStatusSubtitle.Size = new System.Drawing.Size(288, 15);
            this.lblUbahStatusSubtitle.TabIndex = 1;
            this.lblUbahStatusSubtitle.Text = "Anda bisa mengubah status jadwal penerbangan di sini";
            // lblUbahStatusTitle
            this.lblUbahStatusTitle.AutoSize = true;
            this.lblUbahStatusTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUbahStatusTitle.Location = new System.Drawing.Point(20, 20);
            this.lblUbahStatusTitle.Name = "lblUbahStatusTitle";
            this.lblUbahStatusTitle.Size = new System.Drawing.Size(230, 25);
            this.lblUbahStatusTitle.TabIndex = 0;
            this.lblUbahStatusTitle.Text = "Ubah Status Penerbangan";
            // UbahStatusPenerbanganForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 524);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UbahStatusPenerbanganForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Admin";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.Label lblUbahStatusSubtitle;
        private System.Windows.Forms.Label lblUbahStatusTitle;
    }
}


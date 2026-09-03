namespace ContohSoal1
{
    partial class TiketSayaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.picBack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.dataGridTiket = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusTerakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTiket)).BeginInit();
            this.SuspendLayout();
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.LightGray;
            this.picBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBack.Image = global::AdminForm.Properties.Resources.iconAPK;
            this.picBack.Location = new System.Drawing.Point(30, 31);
            this.picBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(44, 45);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 0;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(90, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 48);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tiket Saya";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(94, 74);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(428, 28);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Semua tiket Anda yang aktif akan muncul di sini";
            // 
            // dataGridTiket
            // 
            this.dataGridTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTiket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KodePenerbangan,
            this.Maskapai,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.TanggalKeberangkatan,
            this.WaktuPenerbangan,
            this.StatusTerakhir});
            this.dataGridTiket.Location = new System.Drawing.Point(30, 151);
            this.dataGridTiket.Name = "dataGridTiket";
            this.dataGridTiket.RowHeadersWidth = 62;
            this.dataGridTiket.RowTemplate.Height = 28;
            this.dataGridTiket.Size = new System.Drawing.Size(1143, 529);
            this.dataGridTiket.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // KodePenerbangan
            // 
            this.KodePenerbangan.DataPropertyName = "KodePenerbangan";
            this.KodePenerbangan.HeaderText = "Kode Penerbangan";
            this.KodePenerbangan.MinimumWidth = 8;
            this.KodePenerbangan.Name = "KodePenerbangan";
            this.KodePenerbangan.Width = 150;
            // 
            // Maskapai
            // 
            this.Maskapai.DataPropertyName = "Maskapai";
            this.Maskapai.HeaderText = "Maskapai";
            this.Maskapai.MinimumWidth = 8;
            this.Maskapai.Name = "Maskapai";
            this.Maskapai.Width = 150;
            // 
            // BandaraKeberangkatan
            // 
            this.BandaraKeberangkatan.DataPropertyName = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.HeaderText = "Bandara Keberangkatan";
            this.BandaraKeberangkatan.MinimumWidth = 8;
            this.BandaraKeberangkatan.Name = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.Width = 150;
            // 
            // BandaraTujuan
            // 
            this.BandaraTujuan.DataPropertyName = "BandaraTujuan";
            this.BandaraTujuan.HeaderText = "Bandara Tujuan";
            this.BandaraTujuan.MinimumWidth = 8;
            this.BandaraTujuan.Name = "BandaraTujuan";
            this.BandaraTujuan.Width = 150;
            // 
            // TanggalKeberangkatan
            // 
            this.TanggalKeberangkatan.DataPropertyName = "TanggalKeberangkatan";
            this.TanggalKeberangkatan.HeaderText = "Tanggal Keberangkatan";
            this.TanggalKeberangkatan.MinimumWidth = 8;
            this.TanggalKeberangkatan.Name = "TanggalKeberangkatan";
            this.TanggalKeberangkatan.Width = 150;
            // 
            // WaktuPenerbangan
            // 
            this.WaktuPenerbangan.DataPropertyName = "WaktuPenerbangan";
            this.WaktuPenerbangan.HeaderText = "Waktu Penerbangan";
            this.WaktuPenerbangan.MinimumWidth = 8;
            this.WaktuPenerbangan.Name = "WaktuPenerbangan";
            this.WaktuPenerbangan.Width = 150;
            // 
            // StatusTerakhir
            // 
            this.StatusTerakhir.DataPropertyName = "StatusTerakhir";
            this.StatusTerakhir.HeaderText = "Status Terakhir";
            this.StatusTerakhir.MinimumWidth = 8;
            this.StatusTerakhir.Name = "StatusTerakhir";
            this.StatusTerakhir.Width = 150;
            // 
            // TiketSayaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridTiket);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picBack);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TiketSayaForm";
            this.Text = "Tiket Saya";
            this.Load += new System.EventHandler(this.TiketSayaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTiket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.DataGridView dataGridTiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusTerakhir;
    }
}

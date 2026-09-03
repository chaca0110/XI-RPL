namespace ContohSoal1
{
    partial class ListPenerbanganForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.timeCheck1 = new System.Windows.Forms.CheckBox();
            this.timeCheck2 = new System.Windows.Forms.CheckBox();
            this.timeCheck3 = new System.Windows.Forms.CheckBox();
            this.timeCheck4 = new System.Windows.Forms.CheckBox();
            this.lblUrutkan = new System.Windows.Forms.Label();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.btnTerapkan = new System.Windows.Forms.Button();
            this.dataGridPenerbangan = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaPerTiket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeliTiket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.passengerLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.departureLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPenerbangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(90, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "List Penerbangan";
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.Controls.Add(this.lblFilter);
            this.grpFilter.Controls.Add(this.lblWaktu);
            this.grpFilter.Controls.Add(this.timeCheck1);
            this.grpFilter.Controls.Add(this.timeCheck2);
            this.grpFilter.Controls.Add(this.timeCheck3);
            this.grpFilter.Controls.Add(this.timeCheck4);
            this.grpFilter.Controls.Add(this.lblUrutkan);
            this.grpFilter.Controls.Add(this.sortBox);
            this.grpFilter.Controls.Add(this.btnTerapkan);
            this.grpFilter.Location = new System.Drawing.Point(30, 123);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFilter.Size = new System.Drawing.Size(1110, 215);
            this.grpFilter.TabIndex = 3;
            this.grpFilter.TabStop = false;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(9, 0);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(50, 25);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Filter";
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktu.Location = new System.Drawing.Point(26, 38);
            this.lblWaktu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(185, 25);
            this.lblWaktu.TabIndex = 5;
            this.lblWaktu.Text = "Waktu Keberangkatan";
            // 
            // timeCheck1
            // 
            this.timeCheck1.AutoSize = true;
            this.timeCheck1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck1.Location = new System.Drawing.Point(30, 74);
            this.timeCheck1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeCheck1.Name = "timeCheck1";
            this.timeCheck1.Size = new System.Drawing.Size(143, 29);
            this.timeCheck1.TabIndex = 6;
            this.timeCheck1.Text = "00:00 - 06:00";
            this.timeCheck1.UseVisualStyleBackColor = true;
            // 
            // timeCheck2
            // 
            this.timeCheck2.AutoSize = true;
            this.timeCheck2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck2.Location = new System.Drawing.Point(188, 74);
            this.timeCheck2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeCheck2.Name = "timeCheck2";
            this.timeCheck2.Size = new System.Drawing.Size(143, 29);
            this.timeCheck2.TabIndex = 7;
            this.timeCheck2.Text = "06:00 - 12:00";
            this.timeCheck2.UseVisualStyleBackColor = true;
            // 
            // timeCheck3
            // 
            this.timeCheck3.AutoSize = true;
            this.timeCheck3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck3.Location = new System.Drawing.Point(345, 74);
            this.timeCheck3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeCheck3.Name = "timeCheck3";
            this.timeCheck3.Size = new System.Drawing.Size(143, 29);
            this.timeCheck3.TabIndex = 8;
            this.timeCheck3.Text = "12:00 - 18:00";
            this.timeCheck3.UseVisualStyleBackColor = true;
            // 
            // timeCheck4
            // 
            this.timeCheck4.AutoSize = true;
            this.timeCheck4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck4.Location = new System.Drawing.Point(502, 74);
            this.timeCheck4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeCheck4.Name = "timeCheck4";
            this.timeCheck4.Size = new System.Drawing.Size(143, 29);
            this.timeCheck4.TabIndex = 9;
            this.timeCheck4.Text = "18:00 - 24:00";
            this.timeCheck4.UseVisualStyleBackColor = true;
            // 
            // lblUrutkan
            // 
            this.lblUrutkan.AutoSize = true;
            this.lblUrutkan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrutkan.Location = new System.Drawing.Point(26, 123);
            this.lblUrutkan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrutkan.Name = "lblUrutkan";
            this.lblUrutkan.Size = new System.Drawing.Size(175, 25);
            this.lblUrutkan.TabIndex = 10;
            this.lblUrutkan.Text = "Urutkan Berdasarkan";
            // 
            // sortBox
            // 
            this.sortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Location = new System.Drawing.Point(30, 154);
            this.sortBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(298, 33);
            this.sortBox.TabIndex = 11;
            // 
            // btnTerapkan
            // 
            this.btnTerapkan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTerapkan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerapkan.Location = new System.Drawing.Point(900, 146);
            this.btnTerapkan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTerapkan.Name = "btnTerapkan";
            this.btnTerapkan.Size = new System.Drawing.Size(180, 46);
            this.btnTerapkan.TabIndex = 12;
            this.btnTerapkan.Text = "Terapkan Filter";
            this.btnTerapkan.UseVisualStyleBackColor = true;
            this.btnTerapkan.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // dataGridPenerbangan
            // 
            this.dataGridPenerbangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPenerbangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KodePenerbangan,
            this.Maskapai,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.HargaPerTiket,
            this.Tanggal,
            this.Jam,
            this.BeliTiket});
            this.dataGridPenerbangan.Location = new System.Drawing.Point(30, 368);
            this.dataGridPenerbangan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridPenerbangan.Name = "dataGridPenerbangan";
            this.dataGridPenerbangan.RowHeadersWidth = 62;
            this.dataGridPenerbangan.Size = new System.Drawing.Size(1110, 469);
            this.dataGridPenerbangan.TabIndex = 16;
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
            // HargaPerTiket
            // 
            this.HargaPerTiket.DataPropertyName = "HargaPerTiket";
            this.HargaPerTiket.HeaderText = "Harga";
            this.HargaPerTiket.MinimumWidth = 8;
            this.HargaPerTiket.Name = "HargaPerTiket";
            this.HargaPerTiket.Width = 150;
            // 
            // Tanggal
            // 
            this.Tanggal.DataPropertyName = "Tanggal";
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 8;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 150;
            // 
            // Jam
            // 
            this.Jam.DataPropertyName = "Jam";
            this.Jam.HeaderText = "Jam Berangkat";
            this.Jam.MinimumWidth = 8;
            this.Jam.Name = "Jam";
            this.Jam.Width = 150;
            // 
            // BeliTiket
            // 
            this.BeliTiket.HeaderText = "";
            this.BeliTiket.MinimumWidth = 8;
            this.BeliTiket.Name = "BeliTiket";
            this.BeliTiket.Text = "Beli Tiket";
            this.BeliTiket.UseColumnTextForButtonValue = true;
            this.BeliTiket.Width = 150;
            // 
            // passengerLabel
            // 
            this.passengerLabel.AutoSize = true;
            this.passengerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.passengerLabel.Location = new System.Drawing.Point(805, 78);
            this.passengerLabel.Name = "passengerLabel";
            this.passengerLabel.Size = new System.Drawing.Size(122, 25);
            this.passengerLabel.TabIndex = 22;
            this.passengerLabel.Text = "1 Penumpang";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dateLabel.Location = new System.Drawing.Point(553, 78);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(195, 25);
            this.dateLabel.TabIndex = 23;
            this.dateLabel.Text = "Saturday, 24 May 2023";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.destinationLabel.Location = new System.Drawing.Point(320, 78);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(185, 25);
            this.destinationLabel.TabIndex = 24;
            this.destinationLabel.Text = "Soekarno-Hatta (CGK)";
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.departureLabel.Location = new System.Drawing.Point(96, 78);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(185, 25);
            this.departureLabel.TabIndex = 25;
            this.departureLabel.Text = "Soekarno-Hatta (CGK)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(774, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(522, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(286, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
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
            this.picBack.Click += new System.EventHandler(this.exitIcon_Click);
            // 
            // ListPenerbanganForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passengerLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.dataGridPenerbangan);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picBack);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListPenerbanganForm";
            this.Text = "List Penerbangan";
            this.Load += new System.EventHandler(this.ListPenerbanganForm_Load);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPenerbangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.CheckBox timeCheck1;
        private System.Windows.Forms.CheckBox timeCheck2;
        private System.Windows.Forms.CheckBox timeCheck3;
        private System.Windows.Forms.CheckBox timeCheck4;
        private System.Windows.Forms.Label lblUrutkan;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.Button btnTerapkan;
        private System.Windows.Forms.DataGridView dataGridPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaPerTiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam;
        private System.Windows.Forms.DataGridViewButtonColumn BeliTiket;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label passengerLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label departureLabel;
    }
}

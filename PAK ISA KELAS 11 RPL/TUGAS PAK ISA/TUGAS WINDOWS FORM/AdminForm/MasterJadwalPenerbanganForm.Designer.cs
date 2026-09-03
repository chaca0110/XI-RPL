namespace ContohSoal1
{
    partial class MasterJadwalPenerbanganForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridJadwal = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaPerTiket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.departureTime = new System.Windows.Forms.DateTimePicker();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.departureBox = new System.Windows.Forms.ComboBox();
            this.priceCount = new System.Windows.Forms.NumericUpDown();
            this.durationText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.destinationBox = new System.Windows.Forms.ComboBox();
            this.maskapaiBox = new System.Windows.Forms.ComboBox();
            this.codeText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJadwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.GoToDashboard);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(-1, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 554);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(26, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Logout";
            this.label7.Click += new System.EventHandler(this.Logout);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(17, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ubah Status Penerbangan";
            this.label6.Click += new System.EventHandler(this.GoToUbahStatusPenerbangan);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(17, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Master Kode Promo";
            this.label5.Click += new System.EventHandler(this.GoToKodePromo);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Master Jadwal Penerbangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Master Maskapai";
            this.label3.Click += new System.EventHandler(this.GoToMaskapai);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Master Bandara";
            this.label2.Click += new System.EventHandler(this.GoToBandara);
            // 
            // dataGridJadwal
            // 
            this.dataGridJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJadwal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KodePenerbangan,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.Maskapai,
            this.Tanggal,
            this.Durasi,
            this.HargaPerTiket,
            this.WaktuKeberangkatan,
            this.edit,
            this.hapus});
            this.dataGridJadwal.Location = new System.Drawing.Point(324, 164);
            this.dataGridJadwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridJadwal.Name = "dataGridJadwal";
            this.dataGridJadwal.RowHeadersWidth = 62;
            this.dataGridJadwal.Size = new System.Drawing.Size(832, 242);
            this.dataGridJadwal.TabIndex = 45;
            this.dataGridJadwal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridJadwal_CellClick);
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
            // BandaraKeberangkatan
            // 
            this.BandaraKeberangkatan.DataPropertyName = "BandaraAsal";
            this.BandaraKeberangkatan.HeaderText = "Keberangkatan";
            this.BandaraKeberangkatan.MinimumWidth = 8;
            this.BandaraKeberangkatan.Name = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.Width = 150;
            // 
            // BandaraTujuan
            // 
            this.BandaraTujuan.DataPropertyName = "BandaraTujuan";
            this.BandaraTujuan.HeaderText = "Tujuan";
            this.BandaraTujuan.MinimumWidth = 8;
            this.BandaraTujuan.Name = "BandaraTujuan";
            this.BandaraTujuan.Width = 150;
            // 
            // Maskapai
            // 
            this.Maskapai.DataPropertyName = "Maskapai";
            this.Maskapai.HeaderText = "Maskapai";
            this.Maskapai.MinimumWidth = 8;
            this.Maskapai.Name = "Maskapai";
            this.Maskapai.Width = 150;
            // 
            // Tanggal
            // 
            this.Tanggal.DataPropertyName = "TanggalKeberangkatan";
            this.Tanggal.HeaderText = "Tanggal Keberangkatan";
            this.Tanggal.MinimumWidth = 8;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 150;
            // 
            // Durasi
            // 
            this.Durasi.DataPropertyName = "DurasiPenerbangan";
            this.Durasi.HeaderText = "Durasi Penerbangan";
            this.Durasi.MinimumWidth = 8;
            this.Durasi.Name = "Durasi";
            this.Durasi.Width = 150;
            // 
            // HargaPerTiket
            // 
            this.HargaPerTiket.DataPropertyName = "HargaPerTiket";
            this.HargaPerTiket.HeaderText = "HargaPerTiket";
            this.HargaPerTiket.MinimumWidth = 8;
            this.HargaPerTiket.Name = "HargaPerTiket";
            this.HargaPerTiket.Width = 150;
            // 
            // WaktuKeberangkatan
            // 
            this.WaktuKeberangkatan.DataPropertyName = "WaktuKeberangkatan";
            this.WaktuKeberangkatan.HeaderText = "Waktu Keberangkatan";
            this.WaktuKeberangkatan.MinimumWidth = 8;
            this.WaktuKeberangkatan.Name = "WaktuKeberangkatan";
            this.WaktuKeberangkatan.Width = 150;
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.MinimumWidth = 8;
            this.edit.Name = "edit";
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 150;
            // 
            // hapus
            // 
            this.hapus.HeaderText = "";
            this.hapus.MinimumWidth = 8;
            this.hapus.Name = "hapus";
            this.hapus.Text = "Hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            this.hapus.Width = 150;
            // 
            // departureTime
            // 
            this.departureTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureTime.Location = new System.Drawing.Point(904, 467);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(253, 31);
            this.departureTime.TabIndex = 44;
            // 
            // departureDate
            // 
            this.departureDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureDate.Location = new System.Drawing.Point(904, 428);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(253, 31);
            this.departureDate.TabIndex = 43;
            // 
            // departureBox
            // 
            this.departureBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureBox.FormattingEnabled = true;
            this.departureBox.Location = new System.Drawing.Point(486, 465);
            this.departureBox.Name = "departureBox";
            this.departureBox.Size = new System.Drawing.Size(197, 33);
            this.departureBox.TabIndex = 42;
            // 
            // priceCount
            // 
            this.priceCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCount.Location = new System.Drawing.Point(904, 542);
            this.priceCount.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.priceCount.Name = "priceCount";
            this.priceCount.Size = new System.Drawing.Size(253, 31);
            this.priceCount.TabIndex = 41;
            // 
            // durationText
            // 
            this.durationText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationText.Location = new System.Drawing.Point(904, 505);
            this.durationText.Name = "durationText";
            this.durationText.Size = new System.Drawing.Size(253, 31);
            this.durationText.TabIndex = 40;
            this.durationText.Text = "__ Jam __ Menit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(951, 452);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(713, 468);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(185, 25);
            this.label16.TabIndex = 36;
            this.label16.Text = "Waktu Keberangkatan";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(713, 504);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(170, 25);
            this.label17.TabIndex = 37;
            this.label17.Text = "Durasi Penerbangan";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(713, 544);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 25);
            this.label18.TabIndex = 38;
            this.label18.Text = "Harga per Tiket";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(713, 428);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 25);
            this.label19.TabIndex = 39;
            this.label19.Text = "Tanggal";
            // 
            // destinationBox
            // 
            this.destinationBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Location = new System.Drawing.Point(486, 504);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(197, 33);
            this.destinationBox.TabIndex = 33;
            // 
            // maskapaiBox
            // 
            this.maskapaiBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskapaiBox.FormattingEnabled = true;
            this.maskapaiBox.Location = new System.Drawing.Point(486, 544);
            this.maskapaiBox.Name = "maskapaiBox";
            this.maskapaiBox.Size = new System.Drawing.Size(197, 33);
            this.maskapaiBox.TabIndex = 34;
            // 
            // codeText
            // 
            this.codeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeText.Location = new System.Drawing.Point(486, 426);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(197, 31);
            this.codeText.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(526, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(319, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(387, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Semua jadwal penerbangan akan muncul di sini";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(319, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Dari";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(319, 510);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 25);
            this.label15.TabIndex = 27;
            this.label15.Text = "Ke";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(319, 549);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Maskapai";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(319, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Kode Penerbangan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(318, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 32);
            this.label8.TabIndex = 25;
            this.label8.Text = "Master Jadwal Penerbangan";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(1052, 585);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(104, 34);
            this.saveBtn.TabIndex = 47;
            this.saveBtn.Text = "Simpan";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(929, 585);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(104, 34);
            this.cancelBtn.TabIndex = 46;
            this.cancelBtn.Text = "Batal";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // MasterJadwalPenerbanganForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1169, 631);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.dataGridJadwal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.departureTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.departureDate);
            this.Controls.Add(this.priceCount);
            this.Controls.Add(this.departureBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.durationText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.codeText);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.maskapaiBox);
            this.Name = "MasterJadwalPenerbanganForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3Dashboard";
            this.Load += new System.EventHandler(this.MasterJadwalPenerbanganForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJadwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridJadwal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaPerTiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuKeberangkatan;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
        private System.Windows.Forms.DateTimePicker departureTime;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.ComboBox departureBox;
        private System.Windows.Forms.NumericUpDown priceCount;
        private System.Windows.Forms.TextBox durationText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox destinationBox;
        private System.Windows.Forms.ComboBox maskapaiBox;
        private System.Windows.Forms.TextBox codeText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}
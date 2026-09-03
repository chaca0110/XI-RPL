namespace ContohSoal1
{
    partial class BandaraForm
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
            this.dataGridBandara = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodeIATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Negara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.terminalCount = new System.Windows.Forms.NumericUpDown();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.iataTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBandara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminalCount)).BeginInit();
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
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Master Jadwal Penerbangan";
            this.label4.Click += new System.EventHandler(this.GoToJadwalPenerbangan);
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
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Master Bandara";
            // 
            // dataGridBandara
            // 
            this.dataGridBandara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBandara.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.KodeIATA,
            this.Kota,
            this.Negara,
            this.JumlahTerminal,
            this.Alamat,
            this.hapus,
            this.edit});
            this.dataGridBandara.Location = new System.Drawing.Point(324, 168);
            this.dataGridBandara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridBandara.Name = "dataGridBandara";
            this.dataGridBandara.RowHeadersWidth = 62;
            this.dataGridBandara.Size = new System.Drawing.Size(822, 242);
            this.dataGridBandara.TabIndex = 34;
            this.dataGridBandara.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBandara_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "Nama";
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 8;
            this.Nama.Name = "Nama";
            this.Nama.Width = 150;
            // 
            // KodeIATA
            // 
            this.KodeIATA.DataPropertyName = "KodeIATA";
            this.KodeIATA.HeaderText = "KodeIATA";
            this.KodeIATA.MinimumWidth = 8;
            this.KodeIATA.Name = "KodeIATA";
            this.KodeIATA.Width = 150;
            // 
            // Kota
            // 
            this.Kota.DataPropertyName = "Kota";
            this.Kota.HeaderText = "Kota";
            this.Kota.MinimumWidth = 8;
            this.Kota.Name = "Kota";
            this.Kota.Width = 150;
            // 
            // Negara
            // 
            this.Negara.DataPropertyName = "Negara";
            this.Negara.HeaderText = "Negara";
            this.Negara.MinimumWidth = 8;
            this.Negara.Name = "Negara";
            this.Negara.Width = 150;
            // 
            // JumlahTerminal
            // 
            this.JumlahTerminal.DataPropertyName = "JumlahTerminal";
            this.JumlahTerminal.HeaderText = "JumlahTerminal";
            this.JumlahTerminal.MinimumWidth = 8;
            this.JumlahTerminal.Name = "JumlahTerminal";
            this.JumlahTerminal.Width = 150;
            // 
            // Alamat
            // 
            this.Alamat.DataPropertyName = "Alamat";
            this.Alamat.HeaderText = "Alamat";
            this.Alamat.MinimumWidth = 8;
            this.Alamat.Name = "Alamat";
            this.Alamat.Width = 150;
            // 
            // hapus
            // 
            this.hapus.HeaderText = "";
            this.hapus.MinimumWidth = 8;
            this.hapus.Name = "hapus";
            this.hapus.Text = "hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            this.hapus.Width = 150;
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.MinimumWidth = 8;
            this.edit.Name = "edit";
            this.edit.Text = "edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 150;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(1042, 589);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(104, 34);
            this.saveBtn.TabIndex = 31;
            this.saveBtn.Text = "Simpan";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(919, 589);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(104, 34);
            this.cancelBtn.TabIndex = 30;
            this.cancelBtn.Text = "Batal";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // terminalCount
            // 
            this.terminalCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminalCount.Location = new System.Drawing.Point(856, 432);
            this.terminalCount.Name = "terminalCount";
            this.terminalCount.Size = new System.Drawing.Size(290, 31);
            this.terminalCount.TabIndex = 29;
            // 
            // countryBox
            // 
            this.countryBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(418, 541);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(264, 33);
            this.countryBox.TabIndex = 28;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(418, 430);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(264, 31);
            this.nameTxt.TabIndex = 26;
            // 
            // iataTxt
            // 
            this.iataTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iataTxt.Location = new System.Drawing.Point(418, 467);
            this.iataTxt.Name = "iataTxt";
            this.iataTxt.Size = new System.Drawing.Size(264, 31);
            this.iataTxt.TabIndex = 25;
            // 
            // cityTxt
            // 
            this.cityTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTxt.Location = new System.Drawing.Point(418, 504);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(264, 31);
            this.cityTxt.TabIndex = 27;
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.Location = new System.Drawing.Point(856, 468);
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(290, 106);
            this.addressTxt.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(500, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(319, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(409, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(319, 541);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "Negara";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(319, 505);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Kota";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(319, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "Kode IATA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(713, 473);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 25);
            this.label17.TabIndex = 32;
            this.label17.Text = "Alamat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(713, 432);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 25);
            this.label15.TabIndex = 33;
            this.label15.Text = "Jumlah Terminal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(319, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(318, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Master Bandara";
            // 
            // BandaraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1169, 631);
            this.Controls.Add(this.dataGridBandara);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.terminalCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.iataTxt);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Name = "BandaraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3Dashboard";
            this.Load += new System.EventHandler(this.BandaraForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBandara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminalCount)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridBandara;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeIATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Negara;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.NumericUpDown terminalCount;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox iataTxt;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
    }
}
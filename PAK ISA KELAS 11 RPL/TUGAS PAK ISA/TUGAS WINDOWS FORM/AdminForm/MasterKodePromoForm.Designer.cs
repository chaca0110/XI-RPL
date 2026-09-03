namespace ContohSoal1
{
    partial class MasterKodePromoForm
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
            this.dataGridPromo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersentaseDiskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaksimumDiskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BerlakuSampai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.maxCount = new System.Windows.Forms.NumericUpDown();
            this.percentCount = new System.Windows.Forms.NumericUpDown();
            this.expirationDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.promoText = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentCount)).BeginInit();
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
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(17, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Master Kode Promo";
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
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Master Bandara";
            this.label2.Click += new System.EventHandler(this.GoToBandara);
            // 
            // dataGridPromo
            // 
            this.dataGridPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPromo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Kode,
            this.PersentaseDiskon,
            this.MaksimumDiskon,
            this.BerlakuSampai,
            this.Deskripsi,
            this.edit,
            this.hapus});
            this.dataGridPromo.Location = new System.Drawing.Point(325, 164);
            this.dataGridPromo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridPromo.Name = "dataGridPromo";
            this.dataGridPromo.RowHeadersWidth = 62;
            this.dataGridPromo.Size = new System.Drawing.Size(831, 242);
            this.dataGridPromo.TabIndex = 43;
            this.dataGridPromo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPromo_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Kode
            // 
            this.Kode.DataPropertyName = "Kode";
            this.Kode.HeaderText = "Kode";
            this.Kode.MinimumWidth = 8;
            this.Kode.Name = "Kode";
            this.Kode.Width = 150;
            // 
            // PersentaseDiskon
            // 
            this.PersentaseDiskon.DataPropertyName = "PersentaseDiskon";
            this.PersentaseDiskon.HeaderText = "Persentase Diskon";
            this.PersentaseDiskon.MinimumWidth = 8;
            this.PersentaseDiskon.Name = "PersentaseDiskon";
            this.PersentaseDiskon.Width = 150;
            // 
            // MaksimumDiskon
            // 
            this.MaksimumDiskon.DataPropertyName = "MaksimumDiskon";
            this.MaksimumDiskon.HeaderText = "Maksimum Diskon";
            this.MaksimumDiskon.MinimumWidth = 8;
            this.MaksimumDiskon.Name = "MaksimumDiskon";
            this.MaksimumDiskon.Width = 150;
            // 
            // BerlakuSampai
            // 
            this.BerlakuSampai.DataPropertyName = "BerlakuSampai";
            this.BerlakuSampai.HeaderText = "Berlaku Sampai";
            this.BerlakuSampai.MinimumWidth = 8;
            this.BerlakuSampai.Name = "BerlakuSampai";
            this.BerlakuSampai.Width = 150;
            // 
            // Deskripsi
            // 
            this.Deskripsi.DataPropertyName = "Deskripsi";
            this.Deskripsi.HeaderText = "Deskripsi";
            this.Deskripsi.MinimumWidth = 8;
            this.Deskripsi.Name = "Deskripsi";
            this.Deskripsi.Width = 150;
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
            // maxCount
            // 
            this.maxCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxCount.Location = new System.Drawing.Point(487, 545);
            this.maxCount.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.maxCount.Name = "maxCount";
            this.maxCount.Size = new System.Drawing.Size(197, 31);
            this.maxCount.TabIndex = 42;
            // 
            // percentCount
            // 
            this.percentCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentCount.Location = new System.Drawing.Point(487, 505);
            this.percentCount.Name = "percentCount";
            this.percentCount.Size = new System.Drawing.Size(197, 31);
            this.percentCount.TabIndex = 41;
            // 
            // expirationDate
            // 
            this.expirationDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDate.Location = new System.Drawing.Point(487, 464);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(197, 31);
            this.expirationDate.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(976, 452);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(718, 428);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 25);
            this.label19.TabIndex = 39;
            this.label19.Text = "Deskripsi";
            // 
            // descriptionText
            // 
            this.descriptionText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionText.Location = new System.Drawing.Point(808, 425);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(349, 110);
            this.descriptionText.TabIndex = 36;
            // 
            // promoText
            // 
            this.promoText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promoText.Location = new System.Drawing.Point(487, 426);
            this.promoText.Name = "promoText";
            this.promoText.Size = new System.Drawing.Size(197, 31);
            this.promoText.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(527, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(320, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(402, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Semua kode promo yang terdaftar muncul di sini";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(320, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "Berlaku Sampai";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(320, 510);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 25);
            this.label15.TabIndex = 32;
            this.label15.Text = "Persentase Diskon";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(320, 549);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "Maksimum Diskon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(320, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 25);
            this.label11.TabIndex = 34;
            this.label11.Text = "Kode Promo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(319, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 32);
            this.label8.TabIndex = 35;
            this.label8.Text = "Master Kode Promo";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(1053, 574);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(104, 34);
            this.saveBtn.TabIndex = 49;
            this.saveBtn.Text = "Simpan";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(930, 574);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(104, 34);
            this.cancelBtn.TabIndex = 48;
            this.cancelBtn.Text = "Batal";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // MasterKodePromoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1169, 631);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.dataGridPromo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.maxCount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.percentCount);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.expirationDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.promoText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "MasterKodePromoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3Dashboard";
            this.Load += new System.EventHandler(this.MasterKodePromoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentCount)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridPromo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersentaseDiskon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaksimumDiskon;
        private System.Windows.Forms.DataGridViewTextBoxColumn BerlakuSampai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deskripsi;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
        private System.Windows.Forms.NumericUpDown maxCount;
        private System.Windows.Forms.NumericUpDown percentCount;
        private System.Windows.Forms.DateTimePicker expirationDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox promoText;
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
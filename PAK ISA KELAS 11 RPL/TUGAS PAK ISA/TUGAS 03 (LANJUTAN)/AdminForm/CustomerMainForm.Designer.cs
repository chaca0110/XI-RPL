namespace AdminForm
{
    partial class CustomerMainForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblHalo = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDest = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.lblPassenger = new System.Windows.Forms.Label();
            this.cmbPassenger = new System.Windows.Forms.ComboBox();
            this.picMountain = new System.Windows.Forms.PictureBox();
            this.picPassenger = new System.Windows.Forms.PictureBox();
            this.picDest = new System.Windows.Forms.PictureBox();
            this.picDate = new System.Windows.Forms.PictureBox();
            this.picDepart = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picTicket = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMountain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(102)))), ((int)(((byte)(193)))));
            this.panelTop.Controls.Add(this.picLogout);
            this.panelTop.Controls.Add(this.picTicket);
            this.panelTop.Controls.Add(this.lblBrand);
            this.panelTop.Controls.Add(this.picLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 123);
            this.panelTop.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(117, 45);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(258, 33);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "BROMO AIRLINES";
            // 
            // lblHalo
            // 
            this.lblHalo.AutoSize = true;
            this.lblHalo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHalo.Location = new System.Drawing.Point(33, 146);
            this.lblHalo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHalo.Name = "lblHalo";
            this.lblHalo.Size = new System.Drawing.Size(124, 54);
            this.lblHalo.TabIndex = 1;
            this.lblHalo.Text = "Halo!";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(38, 203);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(396, 28);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Mau terbang ke mana hari ini, [Nama akun]?";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.Location = new System.Drawing.Point(98, 277);
            this.lblDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(141, 28);
            this.lblDepart.TabIndex = 3;
            this.lblDepart.Text = "Berangkat Dari";
            // 
            // txtDepart
            // 
            this.txtDepart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepart.Location = new System.Drawing.Point(102, 315);
            this.txtDepart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(373, 33);
            this.txtDepart.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(98, 392);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(173, 28);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Tanggal Berangkat";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(102, 431);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(373, 33);
            this.dtpDate.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(102, 508);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(225, 54);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Cari Penerbangan";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDest.Location = new System.Drawing.Point(654, 277);
            this.lblDest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(70, 28);
            this.lblDest.TabIndex = 10;
            this.lblDest.Text = "Tujuan";
            // 
            // txtDest
            // 
            this.txtDest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDest.Location = new System.Drawing.Point(658, 315);
            this.txtDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(373, 33);
            this.txtDest.TabIndex = 11;
            // 
            // lblPassenger
            // 
            this.lblPassenger.AutoSize = true;
            this.lblPassenger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassenger.Location = new System.Drawing.Point(654, 392);
            this.lblPassenger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassenger.Name = "lblPassenger";
            this.lblPassenger.Size = new System.Drawing.Size(182, 28);
            this.lblPassenger.TabIndex = 13;
            this.lblPassenger.Text = "Jumlah Penumpang";
            // 
            // cmbPassenger
            // 
            this.cmbPassenger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPassenger.FormattingEnabled = true;
            this.cmbPassenger.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbPassenger.Location = new System.Drawing.Point(658, 431);
            this.cmbPassenger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPassenger.Name = "cmbPassenger";
            this.cmbPassenger.Size = new System.Drawing.Size(373, 36);
            this.cmbPassenger.TabIndex = 14;
            this.cmbPassenger.Text = "1";
            // 
            // picMountain
            // 
            this.picMountain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picMountain.BackColor = System.Drawing.Color.LightGray;
            this.picMountain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMountain.Image = global::AdminForm.Properties.Resources.iconGUNUNG;
            this.picMountain.Location = new System.Drawing.Point(822, 462);
            this.picMountain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMountain.Name = "picMountain";
            this.picMountain.Size = new System.Drawing.Size(377, 230);
            this.picMountain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMountain.TabIndex = 16;
            this.picMountain.TabStop = false;
            // 
            // picPassenger
            // 
            this.picPassenger.BackColor = System.Drawing.Color.LightGray;
            this.picPassenger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPassenger.Image = global::AdminForm.Properties.Resources.orgAPK;
            this.picPassenger.Location = new System.Drawing.Point(600, 392);
            this.picPassenger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPassenger.Name = "picPassenger";
            this.picPassenger.Size = new System.Drawing.Size(44, 45);
            this.picPassenger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassenger.TabIndex = 15;
            this.picPassenger.TabStop = false;
            // 
            // picDest
            // 
            this.picDest.BackColor = System.Drawing.Color.LightGray;
            this.picDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDest.Image = global::AdminForm.Properties.Resources.pswt2APK;
            this.picDest.Location = new System.Drawing.Point(600, 277);
            this.picDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picDest.Name = "picDest";
            this.picDest.Size = new System.Drawing.Size(44, 45);
            this.picDest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDest.TabIndex = 12;
            this.picDest.TabStop = false;
            // 
            // picDate
            // 
            this.picDate.BackColor = System.Drawing.Color.LightGray;
            this.picDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDate.Image = global::AdminForm.Properties.Resources.tglAPK;
            this.picDate.Location = new System.Drawing.Point(44, 392);
            this.picDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picDate.Name = "picDate";
            this.picDate.Size = new System.Drawing.Size(44, 45);
            this.picDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDate.TabIndex = 8;
            this.picDate.TabStop = false;
            // 
            // picDepart
            // 
            this.picDepart.BackColor = System.Drawing.Color.LightGray;
            this.picDepart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDepart.Image = global::AdminForm.Properties.Resources.pswtAPK;
            this.picDepart.Location = new System.Drawing.Point(44, 277);
            this.picDepart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picDepart.Name = "picDepart";
            this.picDepart.Size = new System.Drawing.Size(44, 45);
            this.picDepart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDepart.TabIndex = 5;
            this.picDepart.TabStop = false;
            // 
            // picLogout
            // 
            this.picLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogout.BackColor = System.Drawing.Color.LightGray;
            this.picLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogout.Image = global::AdminForm.Properties.Resources.outAPK;
            this.picLogout.Location = new System.Drawing.Point(1107, 31);
            this.picLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(59, 60);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 3;
            this.picLogout.TabStop = false;
            // 
            // picTicket
            // 
            this.picTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picTicket.BackColor = System.Drawing.Color.LightGray;
            this.picTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTicket.Image = global::AdminForm.Properties.Resources.tiketAPK;
            this.picTicket.Location = new System.Drawing.Point(1023, 45);
            this.picTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTicket.Name = "picTicket";
            this.picTicket.Size = new System.Drawing.Size(59, 46);
            this.picTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTicket.TabIndex = 2;
            this.picTicket.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.LightGray;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = global::AdminForm.Properties.Resources.logoAPK;
            this.picLogo.Location = new System.Drawing.Point(33, 23);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(74, 76);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.picMountain);
            this.Controls.Add(this.picPassenger);
            this.Controls.Add(this.cmbPassenger);
            this.Controls.Add(this.lblPassenger);
            this.Controls.Add(this.picDest);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.picDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.picDepart);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblHalo);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerMainForm";
            this.Text = "Bromo Airlines - Customer";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMountain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.PictureBox picTicket;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Label lblHalo;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.PictureBox picDepart;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.PictureBox picDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picDest;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.PictureBox picPassenger;
        private System.Windows.Forms.Label lblPassenger;
        private System.Windows.Forms.ComboBox cmbPassenger;
        private System.Windows.Forms.PictureBox picMountain;
    }
}


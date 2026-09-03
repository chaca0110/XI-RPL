namespace ContohSoal1
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
            this.logOutBtn = new System.Windows.Forms.PictureBox();
            this.picTicket = new System.Windows.Forms.PictureBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblHalo = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.departureText = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.searchBtn = new System.Windows.Forms.Button();
            this.lblDest = new System.Windows.Forms.Label();
            this.destinationText = new System.Windows.Forms.TextBox();
            this.lblPassenger = new System.Windows.Forms.Label();
            this.picMountain = new System.Windows.Forms.PictureBox();
            this.picPassenger = new System.Windows.Forms.PictureBox();
            this.picDest = new System.Windows.Forms.PictureBox();
            this.picDate = new System.Windows.Forms.PictureBox();
            this.picDepart = new System.Windows.Forms.PictureBox();
            this.passengerCount = new System.Windows.Forms.NumericUpDown();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMountain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(102)))), ((int)(((byte)(193)))));
            this.panelTop.Controls.Add(this.logOutBtn);
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
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBtn.BackColor = System.Drawing.Color.LightGray;
            this.logOutBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logOutBtn.Image = global::AdminForm.Properties.Resources.outAPK;
            this.logOutBtn.Location = new System.Drawing.Point(1107, 31);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(59, 60);
            this.logOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.TabStop = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
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
            this.picTicket.Click += new System.EventHandler(this.picTicket_Click);
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
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(38, 203);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(396, 28);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Mau terbang ke mana hari ini, [Nama akun]?";
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
            // departureText
            // 
            this.departureText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureText.Location = new System.Drawing.Point(102, 315);
            this.departureText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departureText.Name = "departureText";
            this.departureText.Size = new System.Drawing.Size(373, 33);
            this.departureText.TabIndex = 4;
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
            // departureDate
            // 
            this.departureDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureDate.Location = new System.Drawing.Point(102, 431);
            this.departureDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(373, 33);
            this.departureDate.TabIndex = 7;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(102, 508);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(225, 54);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Cari Penerbangan";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            // destinationText
            // 
            this.destinationText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationText.Location = new System.Drawing.Point(658, 315);
            this.destinationText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.destinationText.Name = "destinationText";
            this.destinationText.Size = new System.Drawing.Size(373, 33);
            this.destinationText.TabIndex = 11;
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
            // picMountain
            // 
            this.picMountain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picMountain.BackColor = System.Drawing.Color.LightGray;
            this.picMountain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMountain.Image = global::AdminForm.Properties.Resources.iconGUNUNG;
            this.picMountain.Location = new System.Drawing.Point(874, 505);
            this.picMountain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMountain.Name = "picMountain";
            this.picMountain.Size = new System.Drawing.Size(325, 187);
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
            // passengerCount
            // 
            this.passengerCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerCount.Location = new System.Drawing.Point(658, 433);
            this.passengerCount.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.passengerCount.Name = "passengerCount";
            this.passengerCount.Size = new System.Drawing.Size(373, 34);
            this.passengerCount.TabIndex = 17;
            this.passengerCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.passengerCount);
            this.Controls.Add(this.picMountain);
            this.Controls.Add(this.picPassenger);
            this.Controls.Add(this.lblPassenger);
            this.Controls.Add(this.picDest);
            this.Controls.Add(this.destinationText);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.picDate);
            this.Controls.Add(this.departureDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.picDepart);
            this.Controls.Add(this.departureText);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.lblHalo);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerMainForm";
            this.Text = "Bromo Airlines - Customer";
            this.Load += new System.EventHandler(this.CustomerMainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMountain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.PictureBox picTicket;
        private System.Windows.Forms.PictureBox logOutBtn;
        private System.Windows.Forms.Label lblHalo;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox picDepart;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.TextBox departureText;
        private System.Windows.Forms.PictureBox picDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.PictureBox picDest;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.TextBox destinationText;
        private System.Windows.Forms.PictureBox picPassenger;
        private System.Windows.Forms.Label lblPassenger;
        private System.Windows.Forms.PictureBox picMountain;
        private System.Windows.Forms.NumericUpDown passengerCount;
    }
}


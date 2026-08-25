namespace AdminForm
{
    partial class DetailPenumpangForm
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.flowLayoutPanelPassengers = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnKonfirmasi = new System.Windows.Forms.Button();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPromo = new System.Windows.Forms.Button();
            this.txtPromo = new System.Windows.Forms.TextBox();
            this.lblKodePromo = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDetailPenerbangan = new System.Windows.Forms.Label();
            this.lblMaskapai = new System.Windows.Forms.Label();
            this.lblRute = new System.Windows.Forms.Label();
            this.lblPenerbangan = new System.Windows.Forms.Label();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.picTime = new System.Windows.Forms.PictureBox();
            this.picDate = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.flowLayoutPanelPassengers);
            this.panelLeft.Controls.Add(this.lblSubtitle);
            this.panelLeft.Controls.Add(this.lblTitle);
            this.panelLeft.Controls.Add(this.picBack);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(975, 923);
            this.panelLeft.TabIndex = 0;
            // 
            // flowLayoutPanelPassengers
            // 
            this.flowLayoutPanelPassengers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPassengers.AutoScroll = true;
            this.flowLayoutPanelPassengers.Location = new System.Drawing.Point(30, 123);
            this.flowLayoutPanelPassengers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanelPassengers.Name = "flowLayoutPanelPassengers";
            this.flowLayoutPanelPassengers.Size = new System.Drawing.Size(915, 769);
            this.flowLayoutPanelPassengers.TabIndex = 3;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(94, 74);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(305, 25);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Mohon diisi data semua penumpang";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(90, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(296, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Detail Penumpang";
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.btnKonfirmasi);
            this.panelSidebar.Controls.Add(this.lblTotalValue);
            this.panelSidebar.Controls.Add(this.lblTotal);
            this.panelSidebar.Controls.Add(this.btnPromo);
            this.panelSidebar.Controls.Add(this.txtPromo);
            this.panelSidebar.Controls.Add(this.lblKodePromo);
            this.panelSidebar.Controls.Add(this.lblPass);
            this.panelSidebar.Controls.Add(this.picPass);
            this.panelSidebar.Controls.Add(this.lblTime);
            this.panelSidebar.Controls.Add(this.picTime);
            this.panelSidebar.Controls.Add(this.lblDate);
            this.panelSidebar.Controls.Add(this.picDate);
            this.panelSidebar.Controls.Add(this.lblDetailPenerbangan);
            this.panelSidebar.Controls.Add(this.lblMaskapai);
            this.panelSidebar.Controls.Add(this.lblRute);
            this.panelSidebar.Controls.Add(this.lblPenerbangan);
            this.panelSidebar.Controls.Add(this.panelDivider);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSidebar.Location = new System.Drawing.Point(975, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(525, 923);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnKonfirmasi
            // 
            this.btnKonfirmasi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKonfirmasi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKonfirmasi.Location = new System.Drawing.Point(30, 831);
            this.btnKonfirmasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKonfirmasi.Name = "btnKonfirmasi";
            this.btnKonfirmasi.Size = new System.Drawing.Size(465, 62);
            this.btnKonfirmasi.TabIndex = 16;
            this.btnKonfirmasi.Text = "Konfirmasi Pembayaran";
            this.btnKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTotalValue.Location = new System.Drawing.Point(285, 769);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(201, 38);
            this.lblTotalValue.TabIndex = 15;
            this.lblTotalValue.Text = "IDR 3.425.000";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(30, 777);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(181, 28);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total Pembayaran";
            // 
            // btnPromo
            // 
            this.btnPromo.Location = new System.Drawing.Point(375, 443);
            this.btnPromo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPromo.Name = "btnPromo";
            this.btnPromo.Size = new System.Drawing.Size(120, 40);
            this.btnPromo.TabIndex = 13;
            this.btnPromo.Text = "Pakai";
            this.btnPromo.UseVisualStyleBackColor = true;
            // 
            // txtPromo
            // 
            this.txtPromo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromo.Location = new System.Drawing.Point(30, 445);
            this.txtPromo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPromo.Name = "txtPromo";
            this.txtPromo.Size = new System.Drawing.Size(328, 33);
            this.txtPromo.TabIndex = 12;
            // 
            // lblKodePromo
            // 
            this.lblKodePromo.AutoSize = true;
            this.lblKodePromo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodePromo.Location = new System.Drawing.Point(30, 400);
            this.lblKodePromo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKodePromo.Name = "lblKodePromo";
            this.lblKodePromo.Size = new System.Drawing.Size(128, 28);
            this.lblKodePromo.TabIndex = 11;
            this.lblKodePromo.Text = "Kode Promo";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(90, 338);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(124, 25);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "5 penumpang";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(90, 277);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(117, 25);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "19:50 - 21:25";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(90, 215);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(191, 25);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Monday, 22 May 2023";
            // 
            // lblDetailPenerbangan
            // 
            this.lblDetailPenerbangan.AutoSize = true;
            this.lblDetailPenerbangan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailPenerbangan.Location = new System.Drawing.Point(30, 162);
            this.lblDetailPenerbangan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailPenerbangan.Name = "lblDetailPenerbangan";
            this.lblDetailPenerbangan.Size = new System.Drawing.Size(198, 28);
            this.lblDetailPenerbangan.TabIndex = 4;
            this.lblDetailPenerbangan.Text = "Detail Penerbangan";
            // 
            // lblMaskapai
            // 
            this.lblMaskapai.AutoSize = true;
            this.lblMaskapai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaskapai.ForeColor = System.Drawing.Color.Gray;
            this.lblMaskapai.Location = new System.Drawing.Point(30, 100);
            this.lblMaskapai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaskapai.Name = "lblMaskapai";
            this.lblMaskapai.Size = new System.Drawing.Size(140, 25);
            this.lblMaskapai.TabIndex = 3;
            this.lblMaskapai.Text = "Pelita Air Service";
            // 
            // lblRute
            // 
            this.lblRute.AutoSize = true;
            this.lblRute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRute.Location = new System.Drawing.Point(30, 69);
            this.lblRute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRute.Name = "lblRute";
            this.lblRute.Size = new System.Drawing.Size(316, 25);
            this.lblRute.TabIndex = 2;
            this.lblRute.Text = "Juanda (SUB) -> Soekarno-Hatta (CGK)";
            // 
            // lblPenerbangan
            // 
            this.lblPenerbangan.AutoSize = true;
            this.lblPenerbangan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenerbangan.Location = new System.Drawing.Point(30, 31);
            this.lblPenerbangan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPenerbangan.Name = "lblPenerbangan";
            this.lblPenerbangan.Size = new System.Drawing.Size(135, 28);
            this.lblPenerbangan.TabIndex = 1;
            this.lblPenerbangan.Text = "Penerbangan";
            // 
            // panelDivider
            // 
            this.panelDivider.BackColor = System.Drawing.Color.LightGray;
            this.panelDivider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDivider.Location = new System.Drawing.Point(0, 0);
            this.panelDivider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(2, 923);
            this.panelDivider.TabIndex = 0;
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
            // 
            // picPass
            // 
            this.picPass.BackColor = System.Drawing.Color.LightGray;
            this.picPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPass.Image = global::AdminForm.Properties.Resources.orgAPK;
            this.picPass.Location = new System.Drawing.Point(30, 331);
            this.picPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(36, 37);
            this.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPass.TabIndex = 9;
            this.picPass.TabStop = false;
            // 
            // picTime
            // 
            this.picTime.BackColor = System.Drawing.Color.LightGray;
            this.picTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTime.Image = global::AdminForm.Properties.Resources.jamAPK;
            this.picTime.Location = new System.Drawing.Point(30, 269);
            this.picTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTime.Name = "picTime";
            this.picTime.Size = new System.Drawing.Size(36, 37);
            this.picTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTime.TabIndex = 7;
            this.picTime.TabStop = false;
            // 
            // picDate
            // 
            this.picDate.BackColor = System.Drawing.Color.LightGray;
            this.picDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDate.Image = global::AdminForm.Properties.Resources.tglAPK;
            this.picDate.Location = new System.Drawing.Point(30, 208);
            this.picDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picDate.Name = "picDate";
            this.picDate.Size = new System.Drawing.Size(36, 37);
            this.picDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDate.TabIndex = 5;
            this.picDate.TabStop = false;
            // 
            // DetailPenumpangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 923);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelSidebar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailPenumpangForm";
            this.Text = "Detail Penumpang";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPassengers;
        private System.Windows.Forms.Panel panelDivider;
        private System.Windows.Forms.Label lblPenerbangan;
        private System.Windows.Forms.Label lblRute;
        private System.Windows.Forms.Label lblMaskapai;
        private System.Windows.Forms.Label lblDetailPenerbangan;
        private System.Windows.Forms.PictureBox picDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox picTime;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.Label lblKodePromo;
        private System.Windows.Forms.TextBox txtPromo;
        private System.Windows.Forms.Button btnPromo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Button btnKonfirmasi;
    }
}

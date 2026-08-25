namespace AdminForm
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.chkTime1 = new System.Windows.Forms.CheckBox();
            this.chkTime2 = new System.Windows.Forms.CheckBox();
            this.chkTime3 = new System.Windows.Forms.CheckBox();
            this.chkTime4 = new System.Windows.Forms.CheckBox();
            this.lblUrutkan = new System.Windows.Forms.Label();
            this.cmbUrutkan = new System.Windows.Forms.ComboBox();
            this.btnTerapkan = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.grpFilter.SuspendLayout();
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
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(94, 74);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(645, 28);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Bandara A (BAA) -> Bandara B (BAB) • Wed, 20 May 2026 • 1 Penumpang";
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.Controls.Add(this.lblFilter);
            this.grpFilter.Controls.Add(this.lblWaktu);
            this.grpFilter.Controls.Add(this.chkTime1);
            this.grpFilter.Controls.Add(this.chkTime2);
            this.grpFilter.Controls.Add(this.chkTime3);
            this.grpFilter.Controls.Add(this.chkTime4);
            this.grpFilter.Controls.Add(this.lblUrutkan);
            this.grpFilter.Controls.Add(this.cmbUrutkan);
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
            // chkTime1
            // 
            this.chkTime1.AutoSize = true;
            this.chkTime1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTime1.Location = new System.Drawing.Point(30, 74);
            this.chkTime1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTime1.Name = "chkTime1";
            this.chkTime1.Size = new System.Drawing.Size(143, 29);
            this.chkTime1.TabIndex = 6;
            this.chkTime1.Text = "00:00 - 06:00";
            this.chkTime1.UseVisualStyleBackColor = true;
            // 
            // chkTime2
            // 
            this.chkTime2.AutoSize = true;
            this.chkTime2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTime2.Location = new System.Drawing.Point(188, 74);
            this.chkTime2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTime2.Name = "chkTime2";
            this.chkTime2.Size = new System.Drawing.Size(143, 29);
            this.chkTime2.TabIndex = 7;
            this.chkTime2.Text = "06:00 - 12:00";
            this.chkTime2.UseVisualStyleBackColor = true;
            // 
            // chkTime3
            // 
            this.chkTime3.AutoSize = true;
            this.chkTime3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTime3.Location = new System.Drawing.Point(345, 74);
            this.chkTime3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTime3.Name = "chkTime3";
            this.chkTime3.Size = new System.Drawing.Size(143, 29);
            this.chkTime3.TabIndex = 8;
            this.chkTime3.Text = "12:00 - 18:00";
            this.chkTime3.UseVisualStyleBackColor = true;
            // 
            // chkTime4
            // 
            this.chkTime4.AutoSize = true;
            this.chkTime4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTime4.Location = new System.Drawing.Point(502, 74);
            this.chkTime4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTime4.Name = "chkTime4";
            this.chkTime4.Size = new System.Drawing.Size(143, 29);
            this.chkTime4.TabIndex = 9;
            this.chkTime4.Text = "18:00 - 00:00";
            this.chkTime4.UseVisualStyleBackColor = true;
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
            // cmbUrutkan
            // 
            this.cmbUrutkan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrutkan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUrutkan.FormattingEnabled = true;
            this.cmbUrutkan.Location = new System.Drawing.Point(30, 154);
            this.cmbUrutkan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUrutkan.Name = "cmbUrutkan";
            this.cmbUrutkan.Size = new System.Drawing.Size(298, 33);
            this.cmbUrutkan.TabIndex = 11;
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
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelData.BackColor = System.Drawing.Color.DarkGray;
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Location = new System.Drawing.Point(30, 369);
            this.panelData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1109, 460);
            this.panelData.TabIndex = 4;
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
            // ListPenerbanganForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picBack);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListPenerbanganForm";
            this.Text = "List Penerbangan";
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.CheckBox chkTime1;
        private System.Windows.Forms.CheckBox chkTime2;
        private System.Windows.Forms.CheckBox chkTime3;
        private System.Windows.Forms.CheckBox chkTime4;
        private System.Windows.Forms.Label lblUrutkan;
        private System.Windows.Forms.ComboBox cmbUrutkan;
        private System.Windows.Forms.Button btnTerapkan;
        private System.Windows.Forms.Panel panelData;
    }
}

namespace AdminForm
{
    partial class PassengerCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.cmbTitel = new System.Windows.Forms.ComboBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Penumpang #1";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(15, 50);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(29, 15);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "Titel";
            // 
            // cmbTitel
            // 
            this.cmbTitel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTitel.FormattingEnabled = true;
            this.cmbTitel.Items.AddRange(new object[] {
            "- Pilih Titel -",
            "Tuan",
            "Nyonya",
            "Nona"});
            this.cmbTitel.Location = new System.Drawing.Point(120, 47);
            this.cmbTitel.Name = "cmbTitel";
            this.cmbTitel.Size = new System.Drawing.Size(150, 23);
            this.cmbTitel.TabIndex = 2;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(15, 85);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(87, 15);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Nama Lengkap";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(120, 82);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(300, 23);
            this.txtNama.TabIndex = 4;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.Gray;
            this.lblHint.Location = new System.Drawing.Point(120, 110);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(262, 13);
            this.lblHint.TabIndex = 5;
            this.lblHint.Text = "Isi sesuai KTP/Paspor/SIM (tanpa tanda baca dan gelar)";
            // 
            // PassengerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.cmbTitel);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "PassengerCard";
            this.Size = new System.Drawing.Size(450, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.ComboBox cmbTitel;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblHint;
    }
}

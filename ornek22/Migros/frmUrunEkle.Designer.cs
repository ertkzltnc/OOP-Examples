namespace Migros
{
    partial class frmUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunEkle));
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.dtpUretimTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpSKT = new System.Windows.Forms.DateTimePicker();
            this.txtStok = new System.Windows.Forms.NumericUpDown();
            this.txtFiyat = new System.Windows.Forms.NumericUpDown();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblUretimTarihi = new System.Windows.Forms.Label();
            this.lblSKT = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rdGiyecek = new System.Windows.Forms.RadioButton();
            this.rdYiyecek = new System.Windows.Forms.RadioButton();
            this.lstShow = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBeden = new System.Windows.Forms.Label();
            this.cmbBeden = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(116, 26);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(200, 20);
            this.txtUrun.TabIndex = 0;
            // 
            // dtpUretimTarihi
            // 
            this.dtpUretimTarihi.Location = new System.Drawing.Point(116, 53);
            this.dtpUretimTarihi.Name = "dtpUretimTarihi";
            this.dtpUretimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpUretimTarihi.TabIndex = 1;
            // 
            // dtpSKT
            // 
            this.dtpSKT.Location = new System.Drawing.Point(116, 80);
            this.dtpSKT.Name = "dtpSKT";
            this.dtpSKT.Size = new System.Drawing.Size(200, 20);
            this.dtpSKT.TabIndex = 2;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(116, 106);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(120, 20);
            this.txtStok.TabIndex = 3;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(116, 132);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(120, 20);
            this.txtFiyat.TabIndex = 3;
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(10, 26);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(30, 13);
            this.lblUrun.TabIndex = 4;
            this.lblUrun.Text = "Ürün";
            // 
            // lblUretimTarihi
            // 
            this.lblUretimTarihi.AutoSize = true;
            this.lblUretimTarihi.Location = new System.Drawing.Point(10, 53);
            this.lblUretimTarihi.Name = "lblUretimTarihi";
            this.lblUretimTarihi.Size = new System.Drawing.Size(66, 13);
            this.lblUretimTarihi.TabIndex = 5;
            this.lblUretimTarihi.Text = "Üretim Tarihi";
            // 
            // lblSKT
            // 
            this.lblSKT.AutoSize = true;
            this.lblSKT.Location = new System.Drawing.Point(10, 80);
            this.lblSKT.Name = "lblSKT";
            this.lblSKT.Size = new System.Drawing.Size(101, 13);
            this.lblSKT.TabIndex = 5;
            this.lblSKT.Text = "Son Kullanma Tarihi";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(11, 106);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(29, 13);
            this.lblStok.TabIndex = 5;
            this.lblStok.Text = "Stok";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(11, 132);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(29, 13);
            this.lblFiyat.TabIndex = 5;
            this.lblFiyat.Text = "Fiyat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBeden);
            this.groupBox1.Controls.Add(this.lstShow);
            this.groupBox1.Controls.Add(this.lblBeden);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.rdGiyecek);
            this.groupBox1.Controls.Add(this.rdYiyecek);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblUrun);
            this.groupBox1.Controls.Add(this.lblFiyat);
            this.groupBox1.Controls.Add(this.txtUrun);
            this.groupBox1.Controls.Add(this.lblStok);
            this.groupBox1.Controls.Add(this.dtpUretimTarihi);
            this.groupBox1.Controls.Add(this.lblSKT);
            this.groupBox1.Controls.Add(this.dtpSKT);
            this.groupBox1.Controls.Add(this.lblUretimTarihi);
            this.groupBox1.Controls.Add(this.txtStok);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 427);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(191, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rdGiyecek
            // 
            this.rdGiyecek.AutoSize = true;
            this.rdGiyecek.Location = new System.Drawing.Point(269, 134);
            this.rdGiyecek.Name = "rdGiyecek";
            this.rdGiyecek.Size = new System.Drawing.Size(64, 17);
            this.rdGiyecek.TabIndex = 9;
            this.rdGiyecek.TabStop = true;
            this.rdGiyecek.Text = "Giyecek";
            this.rdGiyecek.UseVisualStyleBackColor = true;
            this.rdGiyecek.CheckedChanged += new System.EventHandler(this.rdGiyecek_CheckedChanged);
            // 
            // rdYiyecek
            // 
            this.rdYiyecek.AutoSize = true;
            this.rdYiyecek.Location = new System.Drawing.Point(269, 119);
            this.rdYiyecek.Name = "rdYiyecek";
            this.rdYiyecek.Size = new System.Drawing.Size(63, 17);
            this.rdYiyecek.TabIndex = 8;
            this.rdYiyecek.TabStop = true;
            this.rdYiyecek.Text = "Yiyecek";
            this.rdYiyecek.UseVisualStyleBackColor = true;
            this.rdYiyecek.CheckedChanged += new System.EventHandler(this.rdYiyecek_CheckedChanged);
            // 
            // lstShow
            // 
            this.lstShow.FormattingEnabled = true;
            this.lstShow.Location = new System.Drawing.Point(3, 224);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(376, 199);
            this.lstShow.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(110, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBeden
            // 
            this.lblBeden.AutoSize = true;
            this.lblBeden.Location = new System.Drawing.Point(14, 162);
            this.lblBeden.Name = "lblBeden";
            this.lblBeden.Size = new System.Drawing.Size(38, 13);
            this.lblBeden.TabIndex = 12;
            this.lblBeden.Text = "Beden";
            // 
            // cmbBeden
            // 
            this.cmbBeden.FormattingEnabled = true;
            this.cmbBeden.Location = new System.Drawing.Point(116, 160);
            this.cmbBeden.Name = "cmbBeden";
            this.cmbBeden.Size = new System.Drawing.Size(121, 21);
            this.cmbBeden.TabIndex = 13;
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 444);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUrunEkle";
            this.Text = "Urun Ekle";
            this.Load += new System.EventHandler(this.frmUrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.DateTimePicker dtpUretimTarihi;
        private System.Windows.Forms.DateTimePicker dtpSKT;
        private System.Windows.Forms.NumericUpDown txtStok;
        private System.Windows.Forms.NumericUpDown txtFiyat;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblUretimTarihi;
        private System.Windows.Forms.Label lblSKT;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstShow;
        private System.Windows.Forms.RadioButton rdGiyecek;
        private System.Windows.Forms.RadioButton rdYiyecek;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbBeden;
        private System.Windows.Forms.Label lblBeden;
    }
}


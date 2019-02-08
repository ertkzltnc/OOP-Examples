namespace FormWindows
{
    partial class KoltukSecimForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBiletAl = new System.Windows.Forms.Button();
            this.lblBiletAdet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(371, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 399);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Location = new System.Drawing.Point(717, 44);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(75, 23);
            this.btnBiletAl.TabIndex = 2;
            this.btnBiletAl.Text = "Bilet Al";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // lblBiletAdet
            // 
            this.lblBiletAdet.AutoSize = true;
            this.lblBiletAdet.Location = new System.Drawing.Point(714, 88);
            this.lblBiletAdet.Name = "lblBiletAdet";
            this.lblBiletAdet.Size = new System.Drawing.Size(58, 13);
            this.lblBiletAdet.TabIndex = 3;
            this.lblBiletAdet.Text = " Bilet Adet:";
            this.lblBiletAdet.Click += new System.EventHandler(this.lblBiletAdet_Click);
            // 
            // KoltukSecimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBiletAdet);
            this.Controls.Add(this.btnBiletAl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KoltukSecimForm";
            this.Text = "KoltukSecimForm";
            this.Load += new System.EventHandler(this.KoltukSecimForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBiletAl;
        private System.Windows.Forms.Label lblBiletAdet;
    }
}
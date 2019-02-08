namespace CayveKahve
{
    partial class Form1
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
            this.grpGenerl = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnDoldur = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grpKahve = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.grpGenerl.SuspendLayout();
            this.grpKahve.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGenerl
            // 
            this.grpGenerl.Controls.Add(this.radioButton2);
            this.grpGenerl.Controls.Add(this.radioButton1);
            this.grpGenerl.Location = new System.Drawing.Point(149, 97);
            this.grpGenerl.Margin = new System.Windows.Forms.Padding(4);
            this.grpGenerl.Name = "grpGenerl";
            this.grpGenerl.Padding = new System.Windows.Forms.Padding(4);
            this.grpGenerl.Size = new System.Drawing.Size(267, 123);
            this.grpGenerl.TabIndex = 0;
            this.grpGenerl.TabStop = false;
            this.grpGenerl.Text = "groupBox1";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(171, 23);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cay";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 23);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kahve";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(132, 37);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Adet";
            // 
            // btnDoldur
            // 
            this.btnDoldur.Location = new System.Drawing.Point(166, 399);
            this.btnDoldur.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(100, 28);
            this.btnDoldur.TabIndex = 3;
            this.btnDoldur.Text = "Doldur";
            this.btnDoldur.UseVisualStyleBackColor = true;
            this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(817, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(182, 285);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // grpKahve
            // 
            this.grpKahve.Controls.Add(this.radioButton4);
            this.grpKahve.Controls.Add(this.radioButton3);
            this.grpKahve.Location = new System.Drawing.Point(157, 244);
            this.grpKahve.Name = "grpKahve";
            this.grpKahve.Size = new System.Drawing.Size(200, 100);
            this.grpKahve.TabIndex = 7;
            this.grpKahve.TabStop = false;
            this.grpKahve.Text = "groupBox2";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(9, 50);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(96, 21);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Cappucino";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(108, 21);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "TürkKahvesi";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpKahve);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDoldur);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpGenerl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpGenerl.ResumeLayout(false);
            this.grpGenerl.PerformLayout();
            this.grpKahve.ResumeLayout(false);
            this.grpKahve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGenerl;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox grpKahve;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}


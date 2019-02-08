using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayveKahve // enum kullanılamadı !!!
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grpKahve.Visible = false;
        }
        
        private void btnDoldur_Click(object sender, EventArgs e)
        {
            try
            {
                int adet;
                Cay cay = new Cay();
                Kahve kahve = new Kahve();
                
                if (radioButton2.Checked)
                {
                    richTextBox1.Text = "" + cay.Doldur();
                    adet = Convert.ToInt32(textBox1.Text);
                    MessageBox.Show(cay.hazirla(adet));


                }
                else if (radioButton1.Checked)
                {
                    grpKahve.Visible = true;
                    if (radioButton3.Checked)
                    {
                        kahve.Doldur();

                        kahve.cesit = Kahve.Cesitler.TürkKahvesi;
                        richTextBox1.Text = "" + kahve.cesit;
                        adet = Convert.ToInt32(textBox1.Text);
                        MessageBox.Show(kahve.hazirla(adet));

                    }
                    else if (radioButton4.Checked)
                    {
                        kahve.Doldur();

                        kahve.cesit = Kahve.Cesitler.Cappucino;
                        richTextBox1.Text = "" + kahve.cesit;

                        adet = Convert.ToInt32(textBox1.Text);
                        MessageBox.Show(kahve.hazirla(adet));
                    }


                }
            }
            catch (Exception ex)
            {

                richTextBox1.Text=""+ex.Message;
            }
        }

       
    }
}

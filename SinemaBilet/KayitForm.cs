using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrarySinema;

namespace FormWindows
{
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
            


        }
        KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
        static public string butonisim;
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
           
            
            KullaniciGirisForm kullaniciGirisForm = new KullaniciGirisForm();
            

            
                kullaniciIslemleri.Ad = txtAdi.Text;
                kullaniciIslemleri.SoyAd = txtSoyadi.Text;
                kullaniciIslemleri.Sifre = txtSifre.Text;
                kullaniciIslemleri.Email = txtEmail.Text;
                kullaniciIslemleri.TelNo = txtTelNo.Text;
                kullaniciIslemleri.KullaniciAdi = txtKullaniciAdi.Text;


                if (kullaniciIslemleri.Kaydet() == false)
                {
                    MessageBox.Show("Kullanici Adi mevcut veye eksik bilgi girisi !!");
                }
                else
                {
                    kullaniciIslemleri.Kaydet();
                    this.Hide();
                    this.btnKayitOl.Text = "Guncelle";
                    kullaniciGirisForm.Show();
                }
            
           
        }

        private void KayitForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Controls.Add(groupBox1);
            //if (btnKayitOl.Text == "Guncelle")
            //{
            //    txtAdi.Text = "" + kullaniciIslemleri.Ad;
            //    txtEmail.Text = "" + kullaniciIslemleri.Email;
            //    txtKullaniciAdi.Text = "" + kullaniciIslemleri.KullaniciAdi;
            //    txtSoyadi.Text = "" + kullaniciIslemleri.SoyAd;
            //    txtTelNo.Text = "" + kullaniciIslemleri.TelNo;
            //}
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
             KullaniciGirisForm kullaniciGirisForm = new KullaniciGirisForm();
            if
       (
           MessageBox.Show
           (
               "Back to Login Page",
               "Back to Login Page Dialog",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2 // hit Enter == No !
           )
           == DialogResult.Yes
       )
            {
            this.Hide();
            kullaniciGirisForm.Show();
              
            }











        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

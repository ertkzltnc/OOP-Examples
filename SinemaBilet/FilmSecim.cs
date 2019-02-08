using ClassLibrarySinema;
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
    public partial class FilmSecim : Form
    {
        public FilmSecim()
        {
            InitializeComponent();
            
        }


        BiletSecimIslemleri biletSec = new BiletSecimIslemleri();
       //public static List<Button> btnsecim = new List<Button>();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KullaniciGirisForm kullaniciGirisForm = new KullaniciGirisForm();
            



            if
      (
          MessageBox.Show
          (
              "Back to Login Page",
              "Back to Login Page Dialog",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning,
              MessageBoxDefaultButton.Button2 // hit Enter == No !
          )
          == DialogResult.Yes
      )
            {
                this.Hide();
                kullaniciGirisForm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciGirisForm kullaniciGirisForm = new KullaniciGirisForm();
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            if
      (
          MessageBox.Show
          (
              "Back to Login Page",
              "Back to Login Page Dialog",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning,
              MessageBoxDefaultButton.Button2 // hit Enter == No !
          )
          == DialogResult.Yes
      )
            {
                string silKullaniciAdi = KullaniciGirisForm.kullaniciAdiSaklama; //kullanici giris kısmında girilen kullanıcı adı kayıt adip indis tespiti icin kullanıyoruz
                kullaniciIslemleri.Sil(silKullaniciAdi);
               
                
                this.Hide();
                kullaniciGirisForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitForm kayitForm = new KayitForm();
            KayitForm.butonisim = "Guncelle";
            
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            if
     (
         MessageBox.Show
         (
             "Back to Login Page",
             "Back to Login Page Dialog",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning,
             MessageBoxDefaultButton.Button2 // hit Enter == No !
         )
         == DialogResult.Yes
     )
            {
                string guncelleKullaniciAdi = KullaniciGirisForm.kullaniciAdiSaklama;
                this.Hide();
                kullaniciIslemleri.Guncelle(guncelleKullaniciAdi);
                kayitForm.Show();

            }
        }

      

        private void FilmSecim_Load(object sender, EventArgs e)
        {
            

           
        }

      

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilmlerForm.OrganizeIsler organizeIsler = new FilmlerForm.OrganizeIsler();
            biletSec.FilmSec(filmler.Organizeİsler);
            organizeIsler.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilmlerForm.CaptainMarvel captainMarvel = new FilmlerForm.CaptainMarvel();
            biletSec.FilmSec(filmler.CaptainMArvel);
            captainMarvel.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            
                ContextMenu cm = new ContextMenu();
            
                cm.MenuItems.Add("Item 1");
                cm.MenuItems.Add("Item 2");
                pictureBox2.ContextMenu = cm;
            
        }
    }
}

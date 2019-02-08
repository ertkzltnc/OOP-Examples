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
    public partial class KullaniciGirisForm : Form
    {
        public KullaniciGirisForm()
        {
            InitializeComponent();
        }
        public static string kullaniciAdiSaklama; // kullanici adı   diger formlar üzerinde kullanacagımız icin saklıyoruz fomlar arası degisken atamak icin static tanımlıyoruz
        private void KullaniciGirisForm_Load(object sender, EventArgs e)
        {
            
            txtKullaniciAdi.Text = "Username";
            txtKullaniciSifre.Text = "********";
            txtKullaniciSifre.ForeColor = Color.Gray;
            txtKullaniciAdi.ForeColor = Color.Gray;
        }

        private void lblYeniKullanici_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitForm kayitform = new KayitForm();
            KayitForm.butonisim = "Kayıt Ol";
            this.Hide();
            kayitform.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            FilmSecim filmSecim = new FilmSecim();
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            //string kullanici = txtKullaniciAdi.Text;
            //string sifre = txtKullaniciSifre.Text;
            kullaniciAdiSaklama = txtKullaniciAdi.Text; // kullanici adi kayit alıyoruz
            if (kullaniciIslemleri.Giris(txtKullaniciAdi.Text, txtKullaniciSifre.Text))
            {
                this.Hide();
                filmSecim.Show();
            }
            else MessageBox.Show("sifre hatali");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if
        (
            MessageBox.Show
            (
                "Quit the Application",
                "Exit Application Dialog",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2 // hit Enter == No !
            )
            == DialogResult.Yes
        )
            {
                Application.Exit();
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            txtKullaniciAdi.ForeColor = Color.Black;
        }

        private void txtKullaniciSifre_TextChanged(object sender, EventArgs e)
        {
            txtKullaniciSifre.ForeColor = Color.Black;
        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
           if (txtKullaniciAdi.Text == "Username")
            {
                txtKullaniciAdi.Text = "";
            }
        }

        private void txtKullaniciSifre_Click(object sender, EventArgs e)
        {
            if(txtKullaniciSifre.Text == "********")
            {
                txtKullaniciSifre.Text = "";
            }
        }
    }
}

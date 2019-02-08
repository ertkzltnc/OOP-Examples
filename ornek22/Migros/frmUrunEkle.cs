using ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Migros
{
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            dtpUretimTarihi.Value = DateTime.Today;
            dtpUretimTarihi.MinDate = DateTime.Today.AddDays(-1);
            dtpSKT.MinDate = DateTime.Today;
            dtpSKT.Value = DateTime.Today.AddYears(1);
            rdYiyecek.Checked = true;
            cmbBeden.Enabled = false;
            lblBeden.Enabled = false;
            //listView1.View = View.Details;
            //listView1.FullRowSelect = true;
            //listView1.Columns.Add("Ürün Adı",100);
            //listView1.Columns.Add("Üretim Tarihi", 100);
            //listView1.Columns.Add("SKT", 100);
            //listView1.Columns.Add("Fiyat", 100);
            //listView1.Columns.Add("Stok Adedi", 100);
            //FakeData.ListeyiYukle();
            cmbBeden.DataSource = Enum.GetNames(typeof(enumBeden)); //Enum.GetNames(typeof(enumBeden)); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdYiyecek.Checked == true)
            {
                Yiyecek yiyecek = new Yiyecek();
                yiyecek.urunAdi = txtUrun.Text;
                yiyecek.UretimTarihi = dtpUretimTarihi.Value;
                yiyecek.SonKullanmaTarihi = dtpSKT.Value;
                yiyecek.stokAdedi = (int)txtStok.Value;
                yiyecek.fiyatı = (int)txtFiyat.Value;
                FakeData.Yiyecekler.Add(yiyecek);
                lstShow.Items.Clear();



                //listView1.Items.Add(FakeData.Yiyecekler);
                foreach (var item in FakeData.Yiyecekler)
                {
                    lstShow.Items.Add(item.urunAdi + " " + item.UretimTarihi);

                }


            }

            else // giyecektir
            {


                Giyecek giyecek = new Giyecek();
                giyecek.Beden = enumBeden.M;
                giyecek.fiyatı = (int)txtFiyat.Value;
                giyecek.urunAdi = txtUrun.Text;
                giyecek.stokAdedi = (int)txtStok.Value;
                FakeData.Giyecekler.Add(giyecek);
              

                lstShow.Items.Clear();
                foreach (var item in FakeData.Giyecekler)
                {
                    lstShow.Items.Add(item.urunAdi + " " + item.Beden);

                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //string secilen = lstShow.SelectedItem.ToString();
            //FakeData.Yiyecekler.Remove(secilen);
            //MessageBox.Show(secilen);


        }

        private void rdYiyecek_CheckedChanged(object sender, EventArgs e)
        {
            cmbBeden.Enabled = false;
            lblBeden.Enabled = false;
            lblUretimTarihi.Enabled = true;
            lblSKT.Enabled = true;
            dtpSKT.Enabled = true;
            dtpUretimTarihi.Enabled = true;
        }

        private void rdGiyecek_CheckedChanged(object sender, EventArgs e)
        {
            cmbBeden.Enabled = true;
            lblBeden.Enabled = true;
            lblUretimTarihi.Enabled = false;
            lblSKT.Enabled = false;
            dtpSKT.Enabled = false;
            dtpUretimTarihi.Enabled = false;

        }
    }
}

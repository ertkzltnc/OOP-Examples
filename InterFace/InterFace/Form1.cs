using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterFace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Oyuncu oyuncu = new Oyuncu();
            oyuncu.Ad = "ert";
            oyuncu.Yas = 23;
            oyuncu.YasamDegeri = 100;
            oyuncu.Silahi = new Avp();
            MessageBox.Show(oyuncu.NisanAl());
        }
    }
}

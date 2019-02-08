using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormWindows.FilmlerForm
{
    public partial class OrganizeIsler : Form
    {
        public OrganizeIsler()
        {
            InitializeComponent();
        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {



            this.Hide();
            KoltukSecimForm koltukSecimForm = new KoltukSecimForm();
            koltukSecimForm.Show();
            
            
            
            
        }

        private void btnFragman_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=p3l7RS8tckE");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilmSecim filmSecim = new FilmSecim();
            filmSecim.Show();
        }
    }
}

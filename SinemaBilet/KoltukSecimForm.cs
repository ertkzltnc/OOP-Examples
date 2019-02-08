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
    public partial class KoltukSecimForm : Form
    {
        public KoltukSecimForm()
        {
            InitializeComponent();
        }
        //FilmSecim fs = new FilmSecim();
        List<Button> btnsecim = new List<Button>();
        
        private void KoltukSecimForm_Load(object sender, EventArgs e)
        {



            for (int i = 0; i < 50; i = i + 10)
            {
                for (int j = 0; j < 100; j += 10)
                {

                    Button btnAdd = new Button();
                    btnAdd.BackColor = Color.LimeGreen;
                    btnAdd.Text = char.ConvertFromUtf32(65 + (j / 10)) + (i / 10 + 1);
                    btnAdd.Name = "BtnAdd" + i / 10;
                    btnsecim.Add( btnAdd);
                    if (BiletSecimBilgileri.btn.Contains(btnAdd.Text))
                    {
                        btnAdd.BackColor = Color.Red;
                        btnAdd.Enabled = false;
                    }
                    btnAdd.Location = new System.Drawing.Point(20 + i * 5, 20 + j * 5);
                    btnAdd.Size = new System.Drawing.Size(40, 30);
                    Controls.Add(btnAdd);
                    btnAdd.Click += new EventHandler(this.DynamicButton_Click);
                    

                    groupBox1.Controls.Add(btnAdd);

                }
            }

            for (int i = 0; i < 50; i = i + 10)
            {
                for (int j = 0; j < 100; j += 10)
                {


                    Button btnAdd = new Button();
                    btnAdd.BackColor = Color.LimeGreen;
                    btnAdd.Text = char.ConvertFromUtf32(65 + (j / 10)) + (i / 10 + 6);
                    btnAdd.Name = "BtnAdd" + (i+j);
                    btnsecim.Add(btnAdd);
                    if (BiletSecimBilgileri.btn.Contains(btnAdd.Text))
                    {
                        btnAdd.BackColor = Color.Red;
                        btnAdd.Enabled = false;
                    }
                    btnAdd.Location = new System.Drawing.Point(20 + i * 5, 20 + j * 5);
                    btnAdd.Size = new System.Drawing.Size(40, 30);
                    Controls.Add(btnAdd);
                    btnAdd.Click += new EventHandler(this.DynamicButton_Click);
                    

                    groupBox2.Controls.Add(btnAdd);

                }
            }

        }


        public int counter =0;

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            BiletSecimIslemleri biletSecimIslemleri = new BiletSecimIslemleri();
            
            Button button = sender as Button;
            
            
                if (button.BackColor == Color.LimeGreen)
                {
                    button.BackColor = Color.Red;
                counter++;
                lblBiletAdet.Text = "Bilet Adeti:" + counter.ToString();
                }
                else
                {
                button.BackColor = Color.LimeGreen;
                    counter--;
                lblBiletAdet.Text = "Bilet Adeti:" + counter.ToString();
                }
            






        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
           
            FilmSecim f = new FilmSecim();
            var yeniButonListesi = btnsecim.Select(x => x);
            foreach (var item in yeniButonListesi)
            {
                if (item.BackColor == Color.Red)
                {
                    item.Enabled = false;
                    BiletSecimBilgileri.btn.Add(item.Text);

                }




            }
            this.Hide();
            f.Show();
        }

        private void lblBiletAdet_Click(object sender, EventArgs e)
        {

        }
    }
    
}

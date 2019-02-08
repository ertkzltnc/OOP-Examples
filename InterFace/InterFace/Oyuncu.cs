using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    class Oyuncu
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public int YasamDegeri { get; set; }
        public Silah Silahi { get; set; }
        public string NisanAl()
        {
            if (Silahi is IYakinlastirilaBilir)
            {
                IYakinlastirilaBilir iy = (IYakinlastirilaBilir)Silahi;
                return (iy.Yakinlastir());

            }
            else return "";

        }
        public void Saldir()
        { 
             
        }
    }
}

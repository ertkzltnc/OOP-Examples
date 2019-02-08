using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urunler
{
    class Yiyecek:Urunler,satis
    {
        public DateTime uretimTarihi;
        public DateTime sonKullanmaTarhi;
        public void RafaYerlestir()
        {
            Console.WriteLine("{0}son kullanma tarihli {1} rafa yerlestirildi",sonKullanmaTarhi,urunAdı);
            Console.WriteLine("{0}  üretim tarihli {1} rafa yerlestirildi",uretimTarihi,urunAdı);
        }
        public void sat(int adet)
        {
            stokAdeti -= adet;
        }
    }
}

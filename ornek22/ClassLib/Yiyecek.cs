using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    //Yiyecek classımızın içinde değişken olarak Üretim tarihi ve
    //    Son kullanma tarihi var.bu classın içinde RafaYerleştir
    //        isimli bir method var bu method parametre almıyor ve
    //        ekrana S.K.T'si X ve Ü.T'si Y olan ürün rafa 
    //        yerleştirildi yazıyor.
    //        Yine bu classın içinde Sat isimli bir
    //        method var bu method içine
    //        adet isimli int bir parametre alıyor
    //        ve gelen adedi stokAdedinden düşüyor.
    public class Yiyecek : Urun, IRafaYerlestir
    {
        public DateTime UretimTarihi;
        public DateTime SonKullanmaTarihi;

        public Yiyecek(DateTime _ut,DateTime skt)
        {
            UretimTarihi = _ut;
            SonKullanmaTarihi = skt;
        }
        public Yiyecek()
        {

        }


        public void RafaYerlestir()
        {
            Console.WriteLine("S.K.T'si {0} ve Ü.T'si {1} olan ürün rafa yerleştirildi", SonKullanmaTarihi, UretimTarihi);
        }



    }
}

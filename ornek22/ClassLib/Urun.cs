using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Urun
    {

        public string urunAdi;
        public int fiyatı;
        public int stokAdedi;

        public void UrunOzellikleri()

        {
            Console.WriteLine("Urunun Özellikleri : Ürün Adı {0} ", urunAdi);
            Console.WriteLine("Ürün Fiyatı {0} ", fiyatı);
            Console.WriteLine("Ürün Stok Adedi {0} ", stokAdedi);
        }

        public void StokDurumu()
        {
            Console.WriteLine("Stokda {0} adet ürün kaldı", stokAdedi);
            
        }

        public void Sat(int adet)
        {
            //stokAdedi = stokAdedi - adet;
            stokAdedi -= adet;
        }
    }
}

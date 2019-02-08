using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urunler
{
    class Urunler
    {
        public string urunAdı;
        public int fiyat;
        public int stokAdeti;
        public void UrunÖzellikleri()
        {
            Console.WriteLine("Urun Özellikleri: Ürün Adı: {0}",urunAdı);
            Console.WriteLine("ürün fiyatı:{0}",fiyat);
            Console.WriteLine("Ürün stok adedi:{0}",stokAdeti);
        }
        public void StokDurum()
        {
            Console.WriteLine("Stokda {0} adet ürün mevcut",stokAdeti);
        }
    }
}

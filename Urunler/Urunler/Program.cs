using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urunler
{
    class Program
    {
        static void Main(string[] args)
        {
            Giyecek giyecek = new Giyecek();
            giyecek.urunAdı = "Kazak";
            giyecek.stokAdeti = 12;
            giyecek.fiyat = 1;
            giyecek.b = beden.m;


            Yiyecek yiyecek = new Yiyecek();
            yiyecek.urunAdı = "pasta";
            yiyecek.stokAdeti = 14;
            yiyecek.fiyat = 2;
            try
            {
                geri:
                int secim = 0;
                Console.WriteLine("Hos Geldiniz");
                Console.WriteLine("Menü ");
                Console.WriteLine("-------------------------" );
                giyecek.UrunÖzellikleri();
                yiyecek.UrunÖzellikleri();
                yiyecek.uretimTarihi = DateTime.Today;
                yiyecek.sonKullanmaTarhi = new DateTime(2019, 03, 01);
                Console.WriteLine("Giyecek icin 1 Yiyecek icin 2");
                secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    Console.WriteLine("giyecek adı:{0}", giyecek.urunAdı);
                    Console.WriteLine("stok adeti:{0}", giyecek.stokAdeti);
                    Console.WriteLine("Kaç tane alinacak");
                    int adet;
                    adet = Convert.ToInt32(Console.ReadLine());
                    giyecek.sat(adet);
                    giyecek.StokDurum();
                    Console.WriteLine( "------------------------");
                    goto geri;

                }
                else if (secim == 2)
                {
                    Console.WriteLine("yiyecek adı:{0}", yiyecek.urunAdı);
                    Console.WriteLine("stok adeti:{0}", yiyecek.stokAdeti);
                    Console.WriteLine("Kaç tane alinacak");
                    int adet;
                    adet = Convert.ToInt32(Console.ReadLine());
                    yiyecek.sat(adet);
                    yiyecek.StokDurum();
                    Console.WriteLine("------------------------");

                    goto geri;
                }
                else
                {
                     giyecek.RafaYerlestir();
                    Console.WriteLine("------------------------");
                    yiyecek.RafaYerlestir();
                    Console.WriteLine("------------------------");

                    goto geri;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("",ex.Message);
            }
            Console.Read();

        }
    }
}

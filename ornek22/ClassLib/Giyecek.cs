using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    //    Giyecek classında ise Beden isimli bir değişken var bu
    //        değişken bir enum değerleri => {XXS,XS,S,M,L,XL,XXL
    //}
    //bu classın içinde RafaYerleştir isimli bir method var
    //    bu method parametre almıyor ve ekrana Bedeni X olan
    //    ürün rafa yerleştirildi yazıyor.
    public enum enumBeden
    {
        XXS, XS, S, M, L, XL, XXL
    }
        
    
    public class Giyecek : Urun,IRafaYerlestir, Idizilebilir
    {
        public enumBeden Beden;

        public void Dizilecek()
        {
            Console.WriteLine("Bedeni {0} olan  ürünler dizilerek toplandı", Beden);
        }

        public void RafaYerlestir()
        {
            Console.WriteLine("Bedeni {0} olan  ürün rafa yerleştirildi", Beden);
        }

    }
}

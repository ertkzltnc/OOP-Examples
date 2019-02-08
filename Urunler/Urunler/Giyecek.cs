using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urunler
{
    public enum beden
    {
        x, xxs, s, m, l
    }
    class Giyecek:Urunler,satis
    {
        public beden b;
        public void sat(int adet)
        {
            stokAdeti -= adet;
        }
        public void RafaYerlestir()
        {
            Console.WriteLine(" {0} rafa yerlestirildi", b );
                
            
        }
    }
}

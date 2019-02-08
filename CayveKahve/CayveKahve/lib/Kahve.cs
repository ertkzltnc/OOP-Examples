using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayveKahve
{
    class Kahve : İcecek, IHazirla
    {
        public enum Cesitler
        {
            TürkKahvesi=0,
            Cappucino=1
        }
        public Cesitler cesit;
        
        public override string Doldur()
        {
            return " Doldurma İslemi Basladi";
            
        }

        public string hazirla(int adet)
        {
            Console.WriteLine(Cesitler.Cappucino);
            return "" + adet;
           

        }

        
    }
}

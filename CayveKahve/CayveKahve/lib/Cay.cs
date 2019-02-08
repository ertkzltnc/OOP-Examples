using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayveKahve
{
    class  Cay : İcecek, IHazirla
    {
        public int sekerAdet;
        

        public override string Doldur()
        {
            return " Doldurma İslemi Basladi";
           
        }

        public string hazirla(int adet)
        {
            return "" + adet + "sekerli cay hazirlandı!!"; ;
        }
    }
}

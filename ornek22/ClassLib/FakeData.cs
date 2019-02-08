using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class FakeData
    {
        public static List<Yiyecek> Yiyecekler = new List<Yiyecek>();
        
        public static List<Giyecek> Giyecekler = new List<Giyecek>();

        public static void ListeyiYukle()
        {
            Yiyecekler.Add(new Yiyecek(DateTime.Parse("01.01.2019"), DateTime.Parse("01.01.2020")) );
            Yiyecekler.Add(new Yiyecek(DateTime.Parse("01.01.2019"), DateTime.Parse("01.01.2020")));
            Yiyecekler.Add(new Yiyecek(DateTime.Parse("01.01.2019"), DateTime.Parse("01.01.2020")));
            Yiyecekler.Add(new Yiyecek(DateTime.Parse("01.01.2019"), DateTime.Parse("01.01.2020")));

        }
    }
}

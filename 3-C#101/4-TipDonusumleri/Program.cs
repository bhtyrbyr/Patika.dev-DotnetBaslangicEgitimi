using System;

namespace _4_TipDonusumleri
{
    class Program
    {

        static void Main(string[] args)
        {
            // Implicit Conversion (bilinçsiz dönüşüm)
/*
            Düşük kapasitesi değişkeni üst kapasitesi değişkene atama yapma işlemidir.
            Atama esnasında hata vermez. Herhangi bir keyword'e ihtiyacı yoktur.
*/

            //Explicit Conversion (bilinçli dönüşüm)

/*
            Kendisinden düşük kapasitesi değişkenlere atama yapma işlemidir.
            Atamanın yapılabilmesi için geliştiricinin müdahalesi gerekir.
            Örnk;   int x = 4 ;
                    byte y = (byte)x;
                    byte y = Convert.ToByte(x);
                    byte y = byte.Parse(x);

*/
        }
    }
}
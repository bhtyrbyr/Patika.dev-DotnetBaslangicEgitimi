using System;

namespace _7_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = int.Parse(Console.ReadLine());
            int ct = 0;
            int tt = 0;       
            for (int i = 0; i < sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    tt += i;
                }else{
                    ct += i;
                }
            }
            Console.WriteLine("Çift Toplam " + ct + " Tek Toplam " + tt);
        }
    }
}

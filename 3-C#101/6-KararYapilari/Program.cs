using System;

namespace _6_KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            if(DateTime.Now.Hour < 6 && DateTime.Now.Hour >18){
                Console.WriteLine("İyi geceler");
            }else{
                Console.WriteLine("İyi günler");
            }
        }
    }
}

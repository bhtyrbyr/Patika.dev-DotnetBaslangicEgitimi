using System;

namespace _6_KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            ifElseDersi();
        }

        static void ifElseDersi()
        {
            int time = DateTime.Now.Hour;
            if(time <= 18){
                Console.WriteLine("İyi günler");
            }else{
                Console.WriteLine("İyi geceler");
            }
        }
    }
}

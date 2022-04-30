using System;

namespace _7_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            ders2while();   
            int[] list = {1,2,3,4,5,6,7,8,9,0};
            ders3foreach(list);
        }

        static void ders3foreach(int[] list){
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void ders2while(){
            int n = int.Parse(Console.ReadLine());
            int i = -1;
            int tot = 0;
            float ort = 0;
            while(true){
                i++;
                tot += i;
                Console.WriteLine(tot);
                if(i == n)
                    break;
                else{
                }
            }
            ort = (float)tot / i;
            Console.WriteLine("Girilen sayi " + n + "\nToplam " + tot + "\nOrt " + ort);
        }
        static void hackerRank(){
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++){

                for(int j = 0; j < (n - (i + 1)); j++){
                    Console.Write(" ");
                }

                for(int k = 0; k < (i + 1); k++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

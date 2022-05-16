using System;
using System.Collections;
namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int[] list = new int[20];
            int[] min = new int[3];
            int[] max = new int[3];
            for(int i = 0 ; i < 20; i++){
                try{
                    
                    number = Convert.ToInt32(Console.ReadLine());
                    if(number < 0 ){
                        Console.WriteLine("Sayı negatif olamaz!!");
                        i--;
                        continue;
                    }

                    list[i] = number;

                }catch{
                    Console.WriteLine("Numerik olmayan değer girilemez");
                }
            }
            Array.Sort(list);
            for(int i = 0; i < 3; i++){
                min[i] = list[i];
                max[i] = list[19 - (2 - i)];
            }
            sonucuYazdir(min);
            sonucuYazdir(max);
            Console.ReadKey();
        }
        static void sonucuYazdir(int[] list){
            int toplam = 0;
            Array.Sort(list);
            string listStr = "";
            foreach (var item in list)
            {
                listStr = listStr + item.ToString() + " ";
                toplam += Convert.ToInt32(item);
            }
            Console.WriteLine("Liste:");
            Console.WriteLine("Eleman sayısı : "+ list.Length + "\n" + listStr);
            Console.WriteLine("\n"+"Listenin Ortalaması = " + (toplam / list.Length).ToString() + "\n");
        }

    }
}

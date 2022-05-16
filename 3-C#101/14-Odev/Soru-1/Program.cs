using System;
using System.Collections;

namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            ArrayList isAsal = new ArrayList();
            ArrayList notAsal = new ArrayList();
            for(int i = 0 ; i < 20; i++){
                try{
                    
                    number = Convert.ToInt32(Console.ReadLine());
                    if(number < 0 ){
                        Console.WriteLine("Sayı negatif olamaz!!");
                        continue;
                    }

                    for(int j = 2; j < number; j++){
                        if( number % j == 0 ){
                            notAsal.Add(number);
                            break;
                        }
                    }

                    if(notAsal.IndexOf(number) == -1){
                        isAsal.Add(number);
                    }

                }catch{
                    Console.WriteLine("Numerik olmayan değer girilemez");
                }
            }
            sonucuYazdir(isAsal);
            sonucuYazdir(notAsal);
            Console.ReadKey();
        }
        
        static void sonucuYazdir(ArrayList list){
            int toplam = 0;
            list.Sort();
            string listStr = "";
            foreach (var item in list)
            {
                listStr = listStr + item.ToString() + " ";
                toplam += Convert.ToInt32(item);
            }
            Console.WriteLine("Asal sayılar");
            Console.WriteLine("Eleman sayısı : "+ list.Count + "\n" + listStr);
            Console.WriteLine("\n"+"Listenin Ortalaması = " + (toplam / list.Count).ToString());
        }
    }
}

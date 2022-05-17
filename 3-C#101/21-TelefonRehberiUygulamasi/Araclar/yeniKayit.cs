using System;
using System.Collections.Generic;

namespace _21_TelefonRehberiUygulamasi
{
    public static class yeniKayit
    {
        public static IslemSonucu YeniKayit(List<Kisi> Rehber){
            Kisi yeniKisi = new Kisi();
            try
            {
               
                Console.WriteLine("Lütfen isim giriniz             :");
                yeniKisi.Name = Console.ReadLine();
                Console.WriteLine("Lütfen soyisim giriniz          :");
                yeniKisi.Surname = Console.ReadLine();
                Console.WriteLine("Lütfen telefon numarası giriniz :");  
                yeniKisi.FirstNumber = Console.ReadLine();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return IslemSonucu.Basarisiz;
            }
            Rehber.Add(yeniKisi);
            Console.WriteLine("\n------------------------------------\n"+
            "Yeni Kişi :\n"+
            "Kişi Biligleri:\n" +
            yeniKisi.ToString()+ "\n" +
            "------------------------------------\n");
            return IslemSonucu.Basarili;
        }
    }
}
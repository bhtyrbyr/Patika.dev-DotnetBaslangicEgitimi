using System;
using System.Collections.Generic;

namespace _21_TelefonRehberiUygulamasi
{
    public static class kayitGuncelle
    {
        public static IslemSonucu KayitGuncelle(List<Kisi> Rehber){
            Console.WriteLine("\nLütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string kisi = Console.ReadLine();
            Boolean kisiBulundu = false;
            int indeks = 0;
            foreach (var item in Rehber)
            {  
                if(kisi.Split(" ")[0] == item.Name && 
                    kisi.Split(" ")[1] == item.Surname)
                {
                    Console.WriteLine(string.Format("{0} kişisi için yeni numarayı girin. >",kisi));
                    item.FirstNumber = Console.ReadLine();
                    kisiBulundu = true;
                    break;
                }
                else{
                    indeks++;
                }
            }
            if(kisiBulundu){
                return IslemSonucu.Basarili;    
            }else{
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                "* Güncelleyemeyi sonlandırmak için : (1)\n"+
                "* Yeniden denemek için             : (2)");
                string secim = Console.ReadLine();
                if(secim == "1"){
                    return IslemSonucu.Basarisiz;
                }else if(secim == "2"){
                    return KayitGuncelle(Rehber);
                }else{
                    Console.WriteLine("Hatalı seçim yaptınız ana menüye yönlendiriliyorsunuz.");
                    return IslemSonucu.Basarisiz;
                }
            }     
        }
    }
}
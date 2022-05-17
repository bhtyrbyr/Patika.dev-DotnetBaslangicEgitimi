using System;
using System.Collections.Generic;

namespace _21_TelefonRehberiUygulamasi
{
    public static class kayitSil
    {
        public static IslemSonucu KayitSil(List<Kisi> Rehber){
            Console.WriteLine("\nLütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string kisi = Console.ReadLine();
            Boolean kisiBulundu = false;
            int indeks = 0;
            foreach (var item in Rehber)
            {  
                if(kisi.Split(" ")[0] == item.Name && 
                    kisi.Split(" ")[1] == item.Surname)
                {
                    Console.WriteLine(string.Format("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",kisi));
                    string onay = Console.ReadLine();
                    if( onay == "y" && onay == "Y"){
                        Rehber.RemoveAt(indeks);
                        kisiBulundu = true;
                        break;
                    }else{
                        break;
                    }
                }
                else{
                    indeks++;
                }
            }
            if(kisiBulundu){
                return IslemSonucu.Basarili;    
            }else{
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                "* Silmeyi sonlandırmak için : (1)\n"+
                "* Yeniden denemek için      : (2)");
                string secim = Console.ReadLine();
                if(secim == "1"){
                    return IslemSonucu.Basarisiz;
                }else if(secim == "2"){
                    return KayitSil(Rehber);
                }else{
                    Console.WriteLine("Hatalı seçim yaptınız ana menüye yönlendiriliyorsunuz.");
                    return IslemSonucu.Basarisiz;
                }
            }     
        }
    }
}
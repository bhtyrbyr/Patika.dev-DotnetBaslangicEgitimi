using System;
using System.Collections.Generic;

namespace _21_TelefonRehberiUygulamasi
{
    public static class rehberdeArama
    {
        public static IslemSonucu RehberdeBulma(List<Kisi> Rehber){
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n" +
                            "**********************************************\n\n" + 
                            "İsim veya soyisime göre arama yapmak için: (1)\n" +
                            "Telefon numarasına göre arama yapmak için: (2)"
                        );   
            string secim = Console.ReadLine();
            switch(secim){
                case "1" :
                {
                    Console.WriteLine("Kişinin ismini veya soyismini girin");
                    string kisi = Console.ReadLine();
                    int eslesmeSayaci = 0;
                    foreach (var item in Rehber)
                    {  
                        if(kisi == item.Name || kisi == item.Surname)
                        {
                            eslesmeSayaci++;
                            Console.WriteLine("Kisi Bulundu ! \n --------------------------------------------");
                            Console.WriteLine(string.Format(
                                "İsim               : {0}\n" +
                                "Soyisim            : {1}\n" +
                                "Telefon Numarası   : {2}",item.Name,item.Surname,item.FirstNumber
                            ));
                        }
                    }
                    Console.WriteLine(string.Format("\"{0}\" araması ile toplam {1} eşleşme bulundu!",kisi,eslesmeSayaci));
                    return IslemSonucu.Basarili;
                }
                case "2" :
                {
                    Console.WriteLine("Kişinin numarasını girin");
                    string numara = Console.ReadLine();
                    Kisi KS = new Kisi();
                    int eslesmeSayaci = 0;
                    foreach (var item in Rehber)
                    {  

                        if(KS.numaraDonusturucu(numara) == item.FirstNumber)
                        {
                            eslesmeSayaci++;
                            Console.WriteLine(string.Format(
                                "İsim               : {0}\n" +
                                "Soyisim            : {1}\n" +
                                "Telefon Numarası   : {2}",item.Name,item.Surname,item.FirstNumber
                            ));
                        }
                    }
                    Console.WriteLine(string.Format("\"{0}\" araması ile toplam {1} eşleşme bulundu!",numara,eslesmeSayaci));
                    return IslemSonucu.Basarili;
                }
                default :
                {
                    Console.WriteLine("Hatalı bir seçim yaptınız. Ana menüye yönlendiriliyorsunuz.");
                    return IslemSonucu.Basarisiz;
                }
            }     
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections;

namespace _21_TelefonRehberiUygulamasi
{
    public static class rehberListele
    {
        public static IslemSonucu RehberListele(List<Kisi> Rehber){
            Console.WriteLine("Rehberi nasıl sıralamaz istersiniz?\n"+
                            "A -> Z (1)\n"+
                            "Z -> A (2)");
            string secim = Console.ReadLine();
            switch(secim)
            {
                case "1"  :
                {
                    ArrayList geciciListe = new ArrayList(Rehber.Count);
                    for(int i = 0; i < Rehber.Count; i++){
                        geciciListe.Add(Rehber[i].ToString());
                    }
                    geciciListe.Sort();
                    Console.WriteLine(" Telefon Rehberi\n"+
                                    "**********************************************");         
                    foreach (var item in geciciListe)
                    {
                        Console.WriteLine(string.Format(
                            "İsim               : {0}\n" +
                            "Soyisim            : {1}\n" +
                            "Telefon Numarası   : {2}",item.ToString().Trim().Split(" ")[0],
                            item.ToString().Split(" ")[1],
                            item.ToString().Split(" ")[2]
                        ));
                        Console.WriteLine("-");
                    }
                    return IslemSonucu.Basarili;
                }
                case "2"  :
                {
                    ArrayList geciciListe = new ArrayList(Rehber.Count);
                    for(int i = 0; i < Rehber.Count; i++){
                        geciciListe.Add(Rehber[i].ToString());
                    }
                    geciciListe.Sort(); geciciListe.Reverse();
                    Console.WriteLine(" Telefon Rehberi\n"+
                                    "**********************************************");         
                    foreach (var item in geciciListe)
                    {
                        Console.WriteLine(string.Format(
                            "İsim               : {0}\n" +
                            "Soyisim            : {1}\n" +
                            "Telefon Numarası   : {2}",item.ToString().Trim().Split(" ")[0],
                            item.ToString().Split(" ")[1],
                            item.ToString().Split(" ")[2]
                        ));
                        Console.WriteLine("-");
                    }
                    return IslemSonucu.Basarili;
                }
                default : 
                {
                    Console.WriteLine("Hatalı seçim yaptınız ana menüye yönlendiriliyorsunuz.!");
                    return IslemSonucu.Basarisiz;
                }
            }                   
        }
    }
}
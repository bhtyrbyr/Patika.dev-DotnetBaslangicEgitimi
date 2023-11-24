using System;
using System.Collections.Generic;
using System.Collections;

namespace _21_TelefonRehberiUygulamasi
{
    public enum Menu{
        YeniKayit = 0,
        KayitSil,
        KayitGuncelle,
        RehberListele,
        RehberdeBulma,
        Hata,
    }
    public enum IslemSonucu{
        Basarili = 0,
        Basarisiz,
    }
    public class App 
    {

        public List<Kisi> Rehber = new List<Kisi>();
        private Boolean ilkCalistirma = true;
        public void start(){
            if(ilkCalistirma){
                ilkKayitYukleme();
                ilkCalistirma = false;
            }
            Menu secim = menuAc();
            switch(secim)
            {
                case Menu.YeniKayit     : 
                {
                    if(yeniKayit.YeniKayit(Rehber) == IslemSonucu.Basarili)  
                        Console.WriteLine("Kişi başarılı bir şekilde kaydedildi.!");
                    else
                        Console.WriteLine("Kişi kaydedilemeedi.!");
                }
                break;
                case Menu.KayitSil      : 
                {
                    if(kayitSil.KayitSil(Rehber) == IslemSonucu.Basarili)  
                        Console.WriteLine("Kişi başarılı bir şekilde silindi.!");
                    else
                        Console.WriteLine("Kişi silinemedi.!");
                }
                break;
                case Menu.KayitGuncelle :
                {
                    if(kayitGuncelle.KayitGuncelle(Rehber) == IslemSonucu.Basarili)  
                        Console.WriteLine("Kişi başarılı bir şekilde güncellendi.!");
                    else
                        Console.WriteLine("Kişi güncellenemedi.!");
                }
                break;
                case Menu.RehberListele : 
                {
                    if(rehberListele.RehberListele(Rehber) == IslemSonucu.Basarili)  
                        Console.WriteLine("Rehber başarılı bir şekilde listelendi.!");
                    else
                        Console.WriteLine("Rehber listelenirken bir hata oluştu.!");
                }
                break;
                case Menu.RehberdeBulma : 
                {
                    if(rehberdeArama.RehberdeBulma(Rehber) == IslemSonucu.Basarili)  
                        Console.WriteLine("Kişi başarılı bir şekilde bulundu.!");
                    else
                        Console.WriteLine("Kişi bulunamadı.!");
                }
                break;
                case Menu.Hata : break;
            }
        }

        private void ilkKayitYukleme()
        {
            string[] ad = {
                "Adem",     "Ahmet",    "Arzu",     "Ayla",
                "Berk",     "Batuhan",  "Beril",    "Bengü",
                "Kemal",    "Adem",    "Kübra",    "Adem",
                "Ersin",    "Tansu",    "Melis",    "Mine",
                "Ziya",     "Adem",   "Ceyda",    "Eylül"
            };
            string[] soyAd = {
                "KIRIK",     "SAVAS",   "DAVUTOGLU",     "INAN",
                "KANTIMUR",     "TURUNC",  "ERGEN",    "YAHSI",
                "SIKINTI",    "CEREMIS",    "BOZAN",    "EDALI",
                "TERLI",    "FIRAT",    "KARA",    "YILDIZ",
                "BEDEL",     "MALAKLI",   "GUNDES",    "YILMAZ"
            };

            for (int i = 0; i < 20; i++)
            {
                Rehber.Add(new Kisi(ad[i], soyAd[i],(5300000000 + i).ToString()));
            }
        }

        private static Menu menuAc()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n" + 
                            "*******************************************\n" +
                            "(1) Yeni Numara Kaydetmek\n" +
                            "(2) Varolan Numarayı Silmek\n" +
                            "(3) Varolan Numarayı Güncelleme\n" +
                            "(4) Rehberi Listelemek\n" +
                            "(5) Rehberde Arama Yapmak");
            try
            {
                byte secim = byte.Parse(Console.ReadLine());
                switch(secim)
                {
                    case 1 : return Menu.YeniKayit; 
                    case 2 : return Menu.KayitSil;
                    case 3 : return Menu.KayitGuncelle;
                    case 4 : return Menu.RehberListele;
                    case 5 : return Menu.RehberdeBulma;
                    default : throw new Exception("Hatalı seçim yapıldı tekrarlayınız !");
                }
            }
            catch (System.Exception EX)
            {
                Console.WriteLine(EX.Message);
                return Menu.Hata;
            }
        }
            
    }
}

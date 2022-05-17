using System;

namespace _16_OOP
{
    public class Hayvanlarr:Canlilar
    {
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir!");
        }
    }
    public class Surungenler:Hayvanlarr
    {
        public Surungenler(){
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.Adaptasyon();
        }
        public void SurunerekHareketEtmek(){
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }
    public class Kuslar:Hayvanlarr
    {
        public Kuslar(){
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.Adaptasyon();
            base.UyaranlaraTepki();
        }
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçar.");
        }
    }
}
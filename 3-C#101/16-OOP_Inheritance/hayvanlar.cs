using System;

namespace _16_OOP
{
    public class Hayvanlarr:Canlilar
    {
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
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
        }
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçar.");
        }
    }
}
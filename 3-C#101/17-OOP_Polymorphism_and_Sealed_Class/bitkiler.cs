using System;

namespace _16_OOP
{
    public class Bitkilerr:Canlilar
    {
        protected void Fotosentez(){
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir!");
        }
    }
    public class TohumluBitkiler:Bitkilerr
    {
        public TohumluBitkiler(){
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.Fotosentez();
            base.UyaranlaraTepki();
        }
        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }
    public class TohumsuzBitkiler:Bitkilerr
    {
        public TohumsuzBitkiler(){
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.Fotosentez();
        }
        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
}
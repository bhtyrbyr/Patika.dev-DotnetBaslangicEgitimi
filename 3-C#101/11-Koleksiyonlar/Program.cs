using System;
using System.Collections.Generic;

namespace _11_Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Colections.Generic
            // t-> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(93);
            sayiListesi.Add(13);
            sayiListesi.Add(33);
            sayiListesi.Add(43);
            sayiListesi.Add(5);

            List<string> renkListesi = new List<string>();
            
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Sarı");
            renkListesi.Add("Mor");
            renkListesi.Add("Morcivert");

            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            foreach (var item in sayiListesi)
            {
                Console.WriteLine(Math.Pow(item,2));
            }
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

            sayiListesi.Remove(5);
            renkListesi.Remove("Mor");
            
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(2);
            
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            if(sayiListesi.Contains(43)){
                Console.WriteLine("43 listede var");
            }

            Console.WriteLine(renkListesi.BinarySearch("Yeşil"));

            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
            List<string> hayvvanlar = new List<string>(hayvanlar);
            hayvvanlar.ForEach(hayvan => Console.WriteLine(hayvan));

            hayvvanlar.Clear();
            hayvvanlar.ForEach(hayvan => Console.WriteLine(hayvan));

            List<test> kullanici = new List<test>();
            test Kullanici1 = new test();
            Kullanici1.Name = "Bahtiyar";
            Kullanici1.Surname = "Bayir";
            Kullanici1.Yas  = 24;

            kullanici.Add(Kullanici1);

            kullanici.ForEach(kk => Console.WriteLine(kk));
        }
    }
    class test{
        private string name;
        private string surname;
        private int yas;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Yas { get => yas; set => yas = value; }

        public override string ToString()
        {
            return name + " " + surname + " " + Yas.ToString();
        }
    }
}

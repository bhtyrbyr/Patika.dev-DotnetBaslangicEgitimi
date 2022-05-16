using System;
using System.Collections;
using System.Collections.Generic;

namespace _12_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();

            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('a');

            Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("************ Add Range *******************");
            string[] renler = {"Kırmızı","Sarı","Yeşil"};
            List<int> sayilar = new List<int>(){1,2,3,4,5,6,7,8,9};
            liste.AddRange(renler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("******* sort **********");

            liste.Sort();
        }
    }
}

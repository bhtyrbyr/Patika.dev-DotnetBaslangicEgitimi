using System;
using System.Collections;
using System.Collections.Generic;

namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> sesliKarakter = new List<char>{ 'a','e','ı','i','u','ü','o','ö'};
            string yazi = Console.ReadLine();
            ArrayList liste = new ArrayList();
            int counter = 0;

            for (int i = 0; i < yazi.Length; i++)
            {
                if(sesliKarakter.Contains(yazi[i]) == true)
                    liste.Add(yazi[i]);
            }

            liste.Sort();
            Console.WriteLine(liste);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

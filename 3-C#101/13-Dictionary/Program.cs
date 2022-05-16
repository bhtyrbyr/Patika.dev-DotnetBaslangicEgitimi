using System;
using System.Collections.Generic;

namespace _13_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10,"Bahtiyar BAYIR");
            kullanicilar.Add(12,"Ziya Başkesen");
            kullanicilar.Add(13,"Özgan KİM");
            //Erişim
            Console.WriteLine("********** elemanlara erişim ************");

            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine(kullanicilar.Count);

            //Contains

            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Özgan KİM"));

            //Remove
            Console.WriteLine("**************remove**************");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Remove
            Console.WriteLine("**************Key**************");
            
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }
            //Remove
            Console.WriteLine("**************Value**************");
            
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}

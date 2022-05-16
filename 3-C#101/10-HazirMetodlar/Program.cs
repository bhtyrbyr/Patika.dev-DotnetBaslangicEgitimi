using System;

namespace _10_HazirMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken1 = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";
/*
            Console.WriteLine(degisken1.Length);

            Console.WriteLine(degisken1.ToUpper());
            Console.WriteLine(degisken1.ToLower());

            Console.WriteLine(string.Concat(degisken1," Merhaba!"));

            Console.WriteLine(degisken1.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken1,degisken2,true));
            Console.WriteLine(string.Compare(degisken1,degisken2,false));

            Console.WriteLine(degisken1.Contains(degisken2));

            Console.WriteLine(degisken1.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken1.StartsWith("Hoşgeldiniz!"));

            Console.WriteLine(degisken1.IndexOf("C-S"));

            Console.WriteLine(degisken1.Insert(0,"Merhaba! "));

            Console.WriteLine(degisken1 + degisken2.PadLeft(30,'!'));

            Console.WriteLine(degisken1.Remove(10));
            Console.WriteLine(degisken1.Remove(3,5));
            Console.WriteLine(degisken1.Remove(0,1));

            Console.WriteLine(degisken1.Replace("CSharp","C#"));
            Console.WriteLine(degisken1.Replace(" ","*"));
*/
            Console.WriteLine(degisken1.Split(" ")[1]);

            Console.WriteLine(degisken1.Substring(4,6));        
        }
    }
}

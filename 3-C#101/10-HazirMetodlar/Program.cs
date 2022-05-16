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

            Console.WriteLine(degisken1.Split(" ")[1]);

            Console.WriteLine(degisken1.Substring(4,6));  

            int count = Convert.ToInt16(Console.ReadLine());
            string[] words = new string[count];
            
            for(int i = 0; i < count; i++){
            
            } 
    
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));

            //Datetime Format

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
*/
            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3));  // 23
            Console.WriteLine(Math.Round(22.3));    // 22
            Console.WriteLine(Math.Round(22.7));    // 23
            Console.WriteLine(Math.Floor(22.7));    // 22

            Console.WriteLine(Math.Min(-2,6));      // -2
            Console.WriteLine(Math.Max(-2,6));      //  6

            Console.WriteLine(Math.Pow(3,4));       //  81
            Console.WriteLine(Math.Sqrt(4));        //  2
            Console.WriteLine(Math.Log(9));         // 9 un e tabanındaki logaritmik karşılığını verir.
            Console.WriteLine(Math.Exp(3));         // e üzeri 3 ü verir.
            Console.WriteLine(Math.Log10(10));      //  10 sayısının logaritma 10 tabanındaki karşılğı.

        }
    }
}

using System;
using System.Collections.Generic;


namespace _9_AlgoritmaSorulariOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            trr:
            Console.WriteLine("İşlem yapmak istediğiniz soru numarasını girin\n1,2,3,4 > ");
            byte select;
            try
            {
                select = byte.Parse(Console.ReadLine());
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Hatalı bir giriş yaptınız hata metniniz>\n\n");
                Console.WriteLine(ex);
                goto trr;
            }
            switch(select){
                case 1 : Sorular.soru1(); break;
                case 2 : Sorular.soru2(); break;
                case 3 : Sorular.soru3(); break;
                case 4 : Sorular.soru4(); break;
                default : Console.WriteLine("Hatalı soru seçimi !");goto trr;
            }
        }
    }
    public static class Sorular
    {
        #region Soru 1
        public static void soru1(int deneme){
            trr:
            Console.WriteLine("Pozitif bir tam sayı girin >");
            byte lim = 0;
            try
            {
                lim = byte.Parse(Console.ReadLine());
            }
            catch (System.Exception ex )
            {
                Console.WriteLine("Hatalı bir giriş yaptınız hata metniniz>\n\n");
                Console.WriteLine(ex);
                goto trr;
            }
            List<int> list = new List<int>();
            for (int i = 0; i < lim; i++)
            {
                Console.WriteLine($"{i+1}. Sayıyı girin >");
                try
                {
                    list.Add(int.Parse(Console.ReadLine()));
                }
                catch (System.Exception)
                {
                    list.Add(0);
                }
            }
            foreach (var item in list)
            {
                if(item % 2 == 0)
                    Console.WriteLine(item);
            }
        }
        #endregion
        #region Soru 2
        public static void soru2(){
            trr:
            Console.WriteLine("Sırasıyla sayı adedini ve kıyaslama sayısını girin >");
            byte lim = 0;
            byte temp = 0;
            try
            {
                lim = byte.Parse(Console.ReadLine());
                temp = byte.Parse(Console.ReadLine());
            }
            catch (System.Exception ex )
            {
                Console.WriteLine("Hatalı bir giriş yaptınız hata metniniz>\n\n");
                Console.WriteLine(ex);
                goto trr;
            }


            List<int> list = new List<int>();
            for (int i = 0; i < lim; i++)
            {
                Console.WriteLine($"{i+1}. Sayıyı girin >");
                try
                {
                    list.Add(int.Parse(Console.ReadLine()));
                }
                catch (System.Exception)
                {
                    list.Add(0);
                }
            }
            foreach (var item in list)
            {
                if(item == temp || item % temp == 0)
                    Console.WriteLine(item);
            }
        }
        #endregion
        #region Soru 3
        public static void soru3(){
            trr:
            Console.WriteLine("Pozitif bir tam sayı girin >");
            byte lim = 0;
            try
            {
                lim = byte.Parse(Console.ReadLine());
            }
            catch (System.Exception ex )
            {
                Console.WriteLine("Hatalı bir giriş yaptınız hata metniniz>\n\n");
                Console.WriteLine(ex);
                goto trr;
            }

            string[] keys = new string[lim];

            for(int i = 0; i < lim; i++){
                keys[i] = Console.ReadLine();
            }

            Console.WriteLine(string.Join("",keys));
        }
        #endregion
        #region Soru 4
        public static void soru4(){
            Console.WriteLine("Dilediğiniz bir cümleyi yazın >");
            string words = Console.ReadLine();
            Console.WriteLine("Harf sayısı : " +words.Length + "\nKelime sayısı : " + words.Split(" ").Length);
        }   
        #endregion
    }
}

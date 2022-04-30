using System;

namespace _8_Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            printHelloWorld();
            bool check = false;
            Console.WriteLine(check.deneme());
        }
        private static void printHelloWorld()
        {
            /*Console.WriteLine("Merhaba Dünya");

            Matematikselİslemler mi = new Matematikselİslemler();
            Console.WriteLine(mi.topla(1,2));
            Console.WriteLine(mi.topla("1","2"));*/
            Rekursif rf = new Rekursif();
            Console.WriteLine(rf.rekursif(2,-4));
            Console.WriteLine(rf.testf());
        }

    }
    public static class Extention{
        public static string deneme(this bool param){
            return "true";
        }
    }
    class Rekursif
    {
        public int testf(int i){
            return 0;
        }
        public string testf(string i){
            return "0";
        }
        public float rekursif(int i, int kuvvet){
            if(kuvvet == 0){
                return 1;
            }
            else if(kuvvet < 0) return 1 / (i * rekursif(i, (kuvvet * (-1)) - 1));
            else if(kuvvet > 0) return i * rekursif(i, kuvvet - 1);
            return 0;
        }
    }
    class Matematikselİslemler
    {
        public int topla(int x, int y){
            return x+y;
        }
        public int topla(string x, string y){
            return Convert.ToInt32(x) + Convert.ToInt32(y);
        }

    }
}

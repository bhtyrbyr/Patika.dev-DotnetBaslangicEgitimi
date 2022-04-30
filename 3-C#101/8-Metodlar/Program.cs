using System;

namespace _8_Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            printHelloWorld();
        }
        private static void printHelloWorld()
        {
            Console.WriteLine("Merhaba Dünya");

            Matematikselİslemler mi = new Matematikselİslemler();
            Console.WriteLine(mi.topla(1,2));
            Console.WriteLine(mi.topla("1","2"));
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

using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name, surname;
            name = Console.ReadLine();
            surname = Console.ReadLine();

            Console.WriteLine(name + ' ' + surname);
            Console.ReadKey();
        }
    }
}

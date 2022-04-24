using System;

namespace degiskenler
{
    class Program
    {

        static void Main(string[] args)
        {
            string dt_str = DateTime.Now.ToString("dd MMMM yyyy HH:dd");

            Console.WriteLine(dt_str);

        }
    }
}

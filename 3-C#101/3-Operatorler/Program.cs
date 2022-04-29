using System;

namespace _3_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            const double meal_cost = 10.25;
            const int tip_percent = 17;
            const int tax_percent = 5;

            Console.WriteLine((meal_cost + meal_cost * ((float)tip_percent / 100) + meal_cost * ((float)tax_percent / 100)));
        }
    }
}

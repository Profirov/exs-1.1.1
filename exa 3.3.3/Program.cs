//using System;

//class Program
//{
//    static void Main()
//    {
//        int numberOfCities = int.Parse(Console.ReadLine());
//        double totalProfit = 0;

//        for (int i = 1; i <= numberOfCities; i++)
//        {
//            string cityName = Console.ReadLine();
//            double income = double.Parse(Console.ReadLine());
//            double expenses = double.Parse(Console.ReadLine());

//            double profit = income - expenses;

//            if (i % 3 == 0 && i % 5 != 0) // Special event every 3rd city
//            {
//                profit += expenses * 0.5;
//            }

//            if (i % 5 == 0) // Rainy city
//            {
//                profit -= income * 0.1;
//            }

//            totalProfit += profit;

//            Console.WriteLine($"In {cityName} Burger Bus earned {profit:F2} leva.");
//        }

//        Console.WriteLine($"Burger Bus total profit: {totalProfit:F2} leva.");
//    }
//}




using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int numberOfCities = int.Parse(Console.ReadLine());
        double totalProfit = 0;

        for (int i = 1; i <= numberOfCities; i++)
        {
            string cityName = Console.ReadLine();
            double income = double.Parse(Console.ReadLine());
            double expenses = double.Parse(Console.ReadLine());

            double profit = income - expenses;

            if (i % 3 == 0 && i % 5 != 0) 
            {
                profit += expenses * 0.5;
            }

            if (i % 5 == 0) 
            {
                profit -= income * 0.1;
            }

            totalProfit += profit ;

            Console.WriteLine($"In {cityName} Burger Bus earned {profit:f2} leva.");
        }

        Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
    }
}


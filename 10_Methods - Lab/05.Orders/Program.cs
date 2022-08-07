using System;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            OrderValue(product, quantity);
        }
        static void OrderValue(string product, int quantity)
        {
            double orderValue = 0;
            switch (product)
            {
                case "coffee": orderValue = quantity * 1.50; break;
                case "water": orderValue = quantity * 1.00; break;
                case "coke": orderValue = quantity * 1.40; break;
                case "snacks": orderValue = quantity * 2.00; break;
            }
            Console.WriteLine($"{orderValue:f2}");
        }
    }
}

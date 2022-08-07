using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double totalSpend = 0;
            while (currentBalance != 0)
            {
                string input = Console.ReadLine();
                double price = 0;
                bool notFound = false;
                switch (input)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    case "Game Time":
                        Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${currentBalance:f2}");
                        return;
                    default:
                        notFound = true;
                        break;
                }
                if (notFound)
                {
                    Console.WriteLine("Not Found");
                }
                else
                {
                    if (currentBalance >= price)
                    {
                        totalSpend += price;
                        currentBalance -= price;
                        Console.WriteLine($"Bought {input}");
                    }
                    else if (currentBalance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
            }
            Console.WriteLine("Out of money!");
        }
    }
}
using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{n * 1.31M:f3}");
        }
    }
}
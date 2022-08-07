using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(decimal)m / 1000:f2}");
        }
    }
}
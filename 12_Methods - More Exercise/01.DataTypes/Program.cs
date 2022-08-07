using System;
using System.Linq;

namespace _01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                Operation(int.Parse(Console.ReadLine()));
            }
            else if (input == "real")
            {
                Operation(double.Parse(Console.ReadLine()));
            }
            else
            {
                Operation(Console.ReadLine());
            }
        }

        static void Operation(int n)
        {
            Console.WriteLine($"{n * 2}");
        }
        static void Operation(double n)
        {
            Console.WriteLine($"{n * 1.5:f2}");
        }
        static void Operation(string input)
        {
            Console.WriteLine($"${input}$");
        }
    }
}
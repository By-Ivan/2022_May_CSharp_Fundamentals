using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}

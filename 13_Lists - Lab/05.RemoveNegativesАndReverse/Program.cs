using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            num.RemoveAll(n => n < 0);

            if (num.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                num.Reverse();
                Console.WriteLine(String.Join(' ', num));
            }
        }
    }
}

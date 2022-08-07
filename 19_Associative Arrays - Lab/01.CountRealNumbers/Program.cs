using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> count = new SortedDictionary<double, int>();
            double[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            foreach (double number in numbers)
            {
                if (!count.ContainsKey(number))
                {
                    count.Add(number, 0);
                }
                count[number]++;
            }

            foreach (KeyValuePair<double, int> keyValuePair in count)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }
    }
}

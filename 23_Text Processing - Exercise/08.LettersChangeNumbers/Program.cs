using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal[] result = new decimal[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char c1 = input[i][0];
                char c2 = input[i][input[i].Length - 1];
                decimal n = decimal.Parse(input[i].Substring(1, input[i].Length - 2));

                if (c1 >= 65 && c1 <= 90)
                {
                    n /= c1 - 'A' + 1;
                }
                else if (c1 >= 97 && c1 <= 122)
                {
                    n *= c1 - 'a' + 1;
                }

                if (c2 >= 65 && c2 <= 90)
                {
                    n -= c2 - 'A' + 1;
                }
                else if (c2 >= 97 && c2 <= 122)
                {
                    n += c2 - 'a' + 1;
                }

                result[i] = n;
            }

            Console.WriteLine($"{result.Sum():f2}");
        }
    }
}

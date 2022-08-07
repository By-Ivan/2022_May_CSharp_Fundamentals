using System;
using System.Text;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string[] items = input.Split();
                long[] n = new long[items.Length];
                int sum = 0;
               for (int j = 0; j < items.Length; j++)
                {
                    n[j] = long.Parse(items[j]);
                }
               if (n[0] > n[1])
                {
                    for (int k = 0; k < items[0].Length; k++)
                    {
                        int digit = items[0][k] - 48;
                        sum += digit;
                    }
                    Console.WriteLine(sum);
                }
               else
                {
                    for (int k = 0; k < items[1].Length; k++)
                    {
                        int digit = items[1][k] - 48;
                        sum += digit;
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int n = num.Count;

            if (n % 2 == 0)
            {
                for (int i = 0; i <= num.Count / 2; i++)
                {
                    num[i] = num[i] + num[num.Count - 1];
                    num.RemoveAt(num.Count - 1);
                }
            }
            else
            {
                for (int i = 0; i < num.Count / 2; i++)
                {
                    num[i] = num[i] + num[num.Count - 1];
                    num.RemoveAt(num.Count - 1);
                }
            }

            Console.WriteLine(String.Join(' ', num));
        }
    }
}

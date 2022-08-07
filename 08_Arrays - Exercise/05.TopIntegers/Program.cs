using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < n.Length - 1; i++)
            {
                int count = 0;
                for (int j = i + 1 ; j < n.Length; j++)
                {
                    if (n[i] > n[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count == n.Length - (i + 1))
                {
                    Console.Write($"{n[i]} ");
                }
            }
            Console.Write($"{n[n.Length - 1]}");
        }
    }
}

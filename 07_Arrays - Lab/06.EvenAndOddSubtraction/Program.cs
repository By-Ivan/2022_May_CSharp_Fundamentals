using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    sumEven += n[i];
                }
                else
                {
                    sumOdd += n[i];
                }
            }
            Console.WriteLine($"{sumEven - sumOdd}");
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bomb = input[0];
            int power = input[1];

            while (num.Contains(bomb))
            {
                int bombIndex = num.FindIndex(n => n == bomb);

                num.RemoveRange(bombIndex - power < 0 ? 0 : bombIndex - power, bombIndex - power < 0 ? bombIndex : power);
                bombIndex = num.FindIndex(n => n == bomb);
                num.RemoveRange(bombIndex, power + 1 > num.Count - 1 ? num.Count - bombIndex : power + 1);
            }
            Console.WriteLine(num.Sum());
        }
    }
}

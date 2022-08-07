using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[n.Length];
            int cycles = n.Length - 1;
            while (cycles > 0)
            {
                for (int i = 0; i < cycles; i++)
                {
                    condensed[i] = n[i] + n[i + 1];
                }
                n = condensed;
                cycles--;
            }
            Console.WriteLine(n[0]);
        }
    }
}

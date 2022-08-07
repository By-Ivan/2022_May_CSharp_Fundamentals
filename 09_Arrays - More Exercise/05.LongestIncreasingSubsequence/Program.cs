using System;
using System.Linq;

namespace _05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] len = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                len[i] = 1;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if ()
                }
            }
        }
    }
}

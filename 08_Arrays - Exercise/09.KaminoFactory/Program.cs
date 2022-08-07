using System;
using System.Linq;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dna = new int[n];
            int[] bestDNA = new int[n];
            string input = string.Empty;
            int maxCount = 0;
            int maxSum = 0;
            int minIndex = int.MaxValue;
            int nDNA = 0;
            int line = 0;
            while (input != "Clone them!")
            {
                dna = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int count = 0;
                int sum = dna.Sum();
                int index = 0;

                for (int i = 0; i < dna.Length - 1; i++)
                {
                    if (dna[i] == 1 && dna[i + 1] == 1)
                    {
                        count++;
                        index = i - count + 1;
                        maxCount = maxCount < count ? count : maxCount;
                    }
                }
                line++;
                if ((count == maxCount && index < minIndex) || (count == maxCount && index == minIndex && sum > maxSum))
                {
                    minIndex = index;
                    nDNA = line;
                    maxSum = sum;
                    bestDNA = dna;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {nDNA} with sum: {maxSum}.");
            Console.WriteLine(String.Join(' ', bestDNA));
        }
    }
}

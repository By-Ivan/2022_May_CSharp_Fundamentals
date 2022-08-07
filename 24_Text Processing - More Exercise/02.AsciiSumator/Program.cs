using System;

namespace _02.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > Math.Min(c1, c2) && input[i] < Math.Max(c1, c2))
                {
                    sum += input[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}

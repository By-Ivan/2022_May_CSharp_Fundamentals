using System;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintNumberOfVowels(input);
        }

        static void PrintNumberOfVowels(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if ("aeouiAEOUI".IndexOf(input[i]) >= 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

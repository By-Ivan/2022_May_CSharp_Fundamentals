using System;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(StringRepat(input, n));
        }

        static string StringRepat(string input, int n)
        {
            string output = string.Empty;
            for (int i = 0; i < n; i++)
            {
                output += input;
            }
            return output;
        }
    }
}

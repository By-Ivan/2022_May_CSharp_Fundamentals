using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            char prevChar = ' ';

            foreach (char c in input)
            {
                if (c != prevChar)
                {
                    result.Append(c);
                }
                prevChar = c;
            }

            Console.WriteLine(result);
        }
    }
}

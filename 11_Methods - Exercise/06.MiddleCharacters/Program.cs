using System;
using System.Text;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacters(input);
        }

        static void PrintMiddleCharacters(string input)
        {
            StringBuilder result = new StringBuilder();

            if (input.Length % 2 == 0)
            {
                result.Append(input[input.Length / 2 - 1]);
                result.Append(input[input.Length / 2]);
            }
            else
            {
                result.Append(input[input.Length / 2]);
            }

            Console.WriteLine(result.ToString());
        }
    }
}

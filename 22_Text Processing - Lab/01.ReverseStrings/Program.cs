using System;
using System.Text;

namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                char[] charArr = input.ToCharArray();
                StringBuilder result = new StringBuilder();

                for (int i = charArr.Length - 1; i >= 0; i--)
                {
                    result.Append(charArr[i]);
                }

                Console.WriteLine($"{input} = {result}");

                input = Console.ReadLine();
            }
        }
    }
}

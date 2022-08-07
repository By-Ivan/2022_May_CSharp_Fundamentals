using System;
using System.Text;

namespace _05.DigitsLettersandOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder[] result = new StringBuilder[3];
            for (int i = 0; i < 3; i++)
            {
                result[i] = new StringBuilder();
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    result[0].Append(input[i]);
                }
                else if (char.IsLetter(input[i]))
                {
                    result[1].Append(input[i]);
                }
                else
                {
                    result[2].Append(input[i]);
                }
            }

            foreach (StringBuilder stringBuilder in result)
            {
                Console.WriteLine(stringBuilder);
            }
        }
    }
}

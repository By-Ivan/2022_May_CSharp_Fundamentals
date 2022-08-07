using System;
using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int explosion = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //abv>1>1>2>2asdasd

                if (input[i] == '>')
                {
                    result.Append(input[i]);
                    explosion += input[i + 1] - '0';
                }
                else if (explosion == 0)
                {
                    result.Append(input[i]);
                }
                else
                {
                    explosion--;
                }
            }
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Text;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            PrintRangeASCII(a, b);
        }

        static void PrintRangeASCII(char a, char b)
        {
            StringBuilder result = new StringBuilder();
            if (a < b)
            {
                for (char c = (char)(Convert.ToInt16(a) + 1); c < b; c++)
                {
                    result.Append(c);
                    result.Append(" ");
                }
            }
            else if (a > b)
            {
                for (char c = (char)(Convert.ToInt16(b) + 1); c < a; c++)
                {
                    result.Append(c);
                    result.Append(" ");
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}

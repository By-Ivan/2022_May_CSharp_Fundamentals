using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            string result = string.Empty;
            if (ch >= 'A' && ch <= 'Z')
            {
                result = "upper-case";
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                result = "lower-case";
            }
            Console.WriteLine(result);
        }
    }
}

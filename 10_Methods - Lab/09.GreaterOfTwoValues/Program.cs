using System;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            
            switch (type)
            {
                case "int": Console.WriteLine(GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()))); break;
                case "char": Console.WriteLine(GetMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()))); break;
                case "string": Console.WriteLine(GetMax(Console.ReadLine(), Console.ReadLine())); break;
            }
        }

        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }

            return b;
            
        }
    }
}
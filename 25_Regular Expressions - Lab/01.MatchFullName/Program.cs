using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            string input = Console.ReadLine();
            MatchCollection matchedNames = regex.Matches(input);
            foreach (Match match in matchedNames)
            {
                Console.Write($"{match.Value} ");
            }
        }
    }
}

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(\+359)+([-]?[\s]?)2(\2)(\d{3})(\2)(\d{4})\b");
            string input = Console.ReadLine();
            MatchCollection phoneMatches = regex.Matches(input);
            string[] matchedPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}

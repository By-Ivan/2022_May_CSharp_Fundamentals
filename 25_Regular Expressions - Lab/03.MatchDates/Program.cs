using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b(?<day>\d{2})(?<delim>[-.\/])(?<month>[A-Z][a-z]{2})\<delim>(?<year>\d{4})\b");
            string input = Console.ReadLine();
            MatchCollection validDates = regex.Matches(input);

            foreach (Match match in validDates)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}

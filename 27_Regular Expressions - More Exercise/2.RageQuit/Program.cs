using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2.RageQuit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<sequence>[ -~-[0-9]]+)(?<count>\d+)");
            StringBuilder result = new StringBuilder();

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string symbols = match.Groups["sequence"].Value.ToUpper();
                int count = int.Parse(match.Groups["count"].Value);

                for (int i = 0; i < count; i++)
                {
                    result.Append(symbols);
                }
            }

            string uniqueSymbols = new string(result.ToString().Distinct().ToArray());

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Length}");
            Console.WriteLine(result.ToString());
        }
    }
}

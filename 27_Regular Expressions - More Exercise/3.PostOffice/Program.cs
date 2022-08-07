using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.PostOffice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex delimiter = new Regex(@"[^|]+");
            string[] message = delimiter.Matches(input).Select(x => x.Value).ToArray();

            Regex letters = new Regex(@"([#$%*&])(?<letters>[A-Z]+)(\1)");
            char[] chars = letters.Match(message[0]).Groups["letters"].Value.ToArray();

            foreach (char c in chars)
            {
                string regexCharCode = (int)c + ":\\d{2}(?!\\d)";

                Regex regexLength = new Regex(regexCharCode);

                int wordLength = int.Parse(regexLength.Match(message[1]).Value.Split(':').ElementAt(1));
                string regexWord = "(?<= |\\A)" + c + "[^ ]{" + wordLength + "}(?= |\\z)";

                Regex word = new Regex(regexWord);

                if (word.IsMatch(message[2]) && wordLength > 0)
                {
                    Console.WriteLine(word.Match(message[2]).Value.ToString().Trim());
                }
            }
        }
    }
}

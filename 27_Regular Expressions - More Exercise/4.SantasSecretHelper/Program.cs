using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _4.SantasSecretHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<string> goodKids = new List<string>();

            while (input != "end")
            {
                input = Decrypt(input, key);

                Regex regex = new Regex(@"(?<=@)(?<name>[A-Za-z]+)[^@\-!:>]*(!(?<behaviour>N|G)!)");

                if (regex.Match(input).Groups["behaviour"].Value == "G")
                {
                    goodKids.Add(regex.Match(input).Groups["name"].Value);
                }

                input = Console.ReadLine();
            }

            goodKids.ForEach(x => Console.WriteLine(x));
        }

        private static string Decrypt(string input, int key)
        {
            StringBuilder message = new StringBuilder();

            foreach (char c in input)
            {
                message.Append((char)((int)c - key));
            }

            return message.ToString();
        }
    }
}

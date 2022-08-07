using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<char, int> charsCount = new Dictionary<char, int>();
            
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    if (!charsCount.ContainsKey(c))
                    {
                        charsCount.Add(c, 0);
                    }

                    charsCount[c]++;
                }
            }

            foreach (KeyValuePair<char, int> keyValuePair in charsCount)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }
    }
}
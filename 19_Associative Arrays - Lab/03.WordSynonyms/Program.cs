using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine().Trim();
                string synonym = Console.ReadLine().Trim();

                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                    dictionary[word].Add(synonym);
                }
                else
                {
                    dictionary[word].Add(synonym);
                }
            }

            foreach (KeyValuePair<string, List<string>> keyValuePair in dictionary)
            {
                Console.WriteLine($"{keyValuePair.Key} - {string.Join(", ", keyValuePair.Value)}");
            }
        }
    }
}

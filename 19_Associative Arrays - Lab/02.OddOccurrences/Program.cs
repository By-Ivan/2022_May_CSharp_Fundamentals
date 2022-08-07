using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(s => s.ToLower()).ToArray();

            foreach (string word in words)
            {
                if (!count.ContainsKey(word))
                {
                    count.Add(word, 0);
                }
                count[word]++;
            }

            foreach (KeyValuePair<string, int> keyValuePair in count)
            {
                if (keyValuePair.Value % 2 != 0)
                {
                    Console.Write(keyValuePair.Key + ' ');
                }
            }
        }
    }
}

using System;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int j = rnd.Next(words.Length);
                string tmp = words[i];
                words[i] = words[j];
                words[j] = tmp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _04.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string result = Translate(input);

            Console.WriteLine(result);
        }

        static string Translate(string[] input)
        {
            Dictionary<string, char> morseCodeAlphabet = new Dictionary<string, char>()
            {
                {".-", 'A'},
                {"-...", 'B'},
                {"-.-.", 'C'},
                {"-..", 'D'},
                {".", 'E'},
                {"..-.", 'F'},
                {"--.", 'G'},
                {"....", 'H'},
                {"..", 'I'},
                {".---", 'J'},
                {"-.-", 'K'},
                {".-..", 'L'},
                {"--", 'M'},
                {"-.", 'N'},
                {"---", 'O'},
                {".--.", 'P'},
                {"--.-", 'Q'},
                {".-.", 'R'},
                {"...", 'S'},
                {"-", 'T'},
                {"..-", 'U'},
                {"...-", 'V'},
                {".--", 'W'},
                {"-..-", 'X'},
                {"-.--", 'Y'},
                {"--..", 'Z'},
                {"|", ' '}
            };

            StringBuilder result = new StringBuilder();

            foreach (string str in input)
            {
                result.Append(morseCodeAlphabet[str]);
            }

            return result.ToString();


        }
    }
}

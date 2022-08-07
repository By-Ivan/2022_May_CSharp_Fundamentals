using System;
using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encrypted = Encrypt(input);
            Console.WriteLine(encrypted);
        }

        private static string Encrypt(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                result.Append((char)(c + 3));
            }

            return result.ToString();
        }
    }
}

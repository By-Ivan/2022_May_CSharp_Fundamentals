using System;
using System.Text;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int number = int.Parse(input);
                bool isPalindrome = CheckIfPalindrome(number);
                Console.WriteLine(isPalindrome.ToString().ToLower());
                input = Console.ReadLine();
            }
        }


        static bool CheckIfPalindrome(int n)
        {
            bool isPalindrome = true;
            char[] number = n.ToString().ToCharArray();
            Array.Reverse(number);
            int reversed = int.Parse(number);

            if (reversed != n)
            {
                isPalindrome = false;
            }

            return isPalindrome;
        }
    }
}

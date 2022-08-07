using System;
using System.Text;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordValidator(password);
        }

        static void PasswordValidator(string password)
        {
            bool isValid = true;
            if (CheckCharacters(password))
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (CheckLettersDigits(password))
            {
                isValid = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (CheckDigitsCount(password))
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
            return;
        }

        static bool CheckCharacters(string password)
        {
            bool result = false;

            if (password.Length < 6 || password.Length > 10)
            {
                result = true;
            }

            return result;
        }
        static bool CheckLettersDigits(string password)
        {
            bool result = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLetterOrDigit(password[i]) == false)
                {
                    result = true;
                }
            }

            return result;
        }
        static bool CheckDigitsCount(string password)
        {
            bool result = false;
            int countDigits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if ("0123456789".IndexOf(password[i]) != -1)
                {
                    countDigits++;
                }
            }
            if (countDigits < 2)
            {
                result = true;
            }

            return result;
        }
    }
}

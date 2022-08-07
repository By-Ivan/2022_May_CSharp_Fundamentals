using System;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string username in usernames)
            {
                if (IsValid(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool IsValid(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            for (int i = 0; i < username.Length; i++)
            {
                if (!char.IsLetter(username[i])
                    && !char.IsDigit(username[i])
                    && username[i] != '-'
                    && username[i] != '_')
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<user>(?<![!-~])[A-Za-z0-9]+[\.\-_]?[A-Za-z0-9]+)@(?<host>([A-Za-z]+[-]?[A-Za-z]+\.)+[A-Za-z]+)");
            MatchCollection emails = regex.Matches(Console.ReadLine());
            foreach (string email in emails.Select(x => x.Value))
            {
                Console.WriteLine(email);
            }
        }
    }
}

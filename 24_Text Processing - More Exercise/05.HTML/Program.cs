using System;
using System.Text;
using System.Collections.Generic;

namespace _05.HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string input = Console.ReadLine();
            List<string> comments = new List<string>();

            while (input != "end of comments")
            {
                comments.Add(input);
                input = Console.ReadLine();
            }

            Console.WriteLine($"<h1>{Environment.NewLine}{(char)9}{title}{Environment.NewLine}</h1>");
            Console.WriteLine($"<article>{Environment.NewLine}{(char)9}{content}{Environment.NewLine}</article>");
            foreach (string comment in comments)
            {
                Console.WriteLine($"<div>{Environment.NewLine}{(char)9}{comment}{Environment.NewLine}</div>");
            }
        }
    }
}
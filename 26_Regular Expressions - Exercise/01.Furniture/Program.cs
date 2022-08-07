using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@">>(?<product>[A-Z]*[a-z]*)<<(?<price>\d{1,}\.?\d{1,})!(?<quantity>\d{1,})");
            List<string> products = new List<string>();
            decimal sum = 0;

            while (input != "Purchase")
            {
                if (regex.IsMatch(input))
                {
                    string product = regex.Match(input).Groups["product"].Value;
                    decimal price = decimal.Parse(regex.Match(input).Groups["price"].Value);
                    int quantity = int.Parse(regex.Match(input).Groups["quantity"].Value);

                    products.Add(product);
                    sum += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            products.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }

}

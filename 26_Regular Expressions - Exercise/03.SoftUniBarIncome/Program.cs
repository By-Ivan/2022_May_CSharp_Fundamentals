using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"%(?<customer>[A-Z][a-z]+)%.*<(?<product>\w+)>.*\|(?<count>\d+)\|.*?(?<price>[\d]+.?[\d]+)?\$");
            double totalIncome = 0;

            while (input != "end of shift")
            {
                if (regex.IsMatch(input))
                {
                    string customerName = regex.Match(input).Groups["customer"].Value;
                    string productName = regex.Match(input).Groups["product"].Value;
                    int productCount = int.Parse(regex.Match(input).Groups["count"].Value);
                    double productPrice = double.Parse(regex.Match(input).Groups["price"].Value);

                    Console.WriteLine($"{customerName}: {productName} - {productCount * productPrice:f2}");
                    totalIncome += productPrice * productCount;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}

using System;
using System.Collections.Generic;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productsPrices = new Dictionary<string, double>();
            Dictionary<string, int> productsQuantities = new Dictionary<string, int>();


            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] cmd = input.Split();
                string product = cmd[0];
                double price = double.Parse(cmd[1]);
                int quantity = int.Parse(cmd[2]);

                if (!productsPrices.ContainsKey(product))
                {
                    productsPrices.Add(product, price);
                    productsQuantities.Add(product, quantity);
                }
                else if (productsPrices.ContainsKey(product))
                {
                    productsPrices[product] = price;
                    productsQuantities[product] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, double> keyValuePair in productsPrices)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value * productsQuantities[keyValuePair.Key]:f2}");
            }
        }
    }
}

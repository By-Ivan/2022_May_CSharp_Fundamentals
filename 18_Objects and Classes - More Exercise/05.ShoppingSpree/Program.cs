using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputPeople = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Person> people = new List<Person>(); ;
            string[] inputProducts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Product> products = new List<Product>();

            FillListOfPeople(inputPeople, people);

            FillListOfProducts(inputProducts, products);

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string person = command[0];
                string product = command[1];
                int indexPerson = people.FindIndex(x => x.Name == person);
                int indexProduct = products.FindIndex(x => x.Name == product);

                if (people[indexPerson].Money >= products[indexProduct].Cost)
                {
                    Console.WriteLine($"{person} bought {product}");
                    people[indexPerson].Money -= products[indexProduct].Cost;
                    people[indexPerson].Products.Add(products[indexProduct]);
                }
                else
                {
                    Console.WriteLine($"{person} can't afford {product}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", people));
        }

        static void FillListOfPeople(string[] inputPeople, List<Person> people)
        {
            for (int i = 0; i < inputPeople.Length; i++)
            {
                string[] personInfo = inputPeople[i].Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();
                Person person = new Person(personInfo[0], decimal.Parse(personInfo[1]));
                people.Add(person);
            }
        }

        static void FillListOfProducts(string[] inputProducts, List<Product> products)
        {
            for (int i = 0; i < inputProducts.Length; i++)
            {
                string[] productInfo = inputProducts[i].Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();
                Product product = new Product(productInfo[0], decimal.Parse(productInfo[1]));
                products.Add(product);
            }
        }
    }

    class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<Product> Products { get; set; }
        public override string ToString()
        {
            string output = this.Name + " - ";

            if (Products.Count == 0)
            {
                output += "Nothing bought";
            }
            else
            {
                output += string.Join(", ", Products);
            }
            return output;
        }
    }

    class Product
    {
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }
        public decimal Cost { get; set; }

        public override string ToString() => $"{Name}";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Advertisement adv = new Advertisement();
                Console.WriteLine(adv.Phrase + " " + adv.Event + " " + adv.Author + " - " + adv.City);
            }
        }

        class Advertisement
        {
            public Advertisement()
            {
                Phrase = phrases[rnd.Next(0, phrases.Count)];
                Event = events[rnd.Next(0, events.Count)];
                Author = authors[rnd.Next(0, authors.Count)];
                City = cities[rnd.Next(0, cities.Count)];
            }

            public string Phrase { get; set; }

            public string Event { get; set; }

            public string Author { get; set; }

            public string City { get; set; }

            List<string> phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();
        }
    }
}

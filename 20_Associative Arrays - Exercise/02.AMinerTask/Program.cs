using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "stop")
            {
                if (!resourses.ContainsKey(input))
                {
                    resourses.Add(input, 0);
                }

                int quantity = int.Parse(Console.ReadLine());

                resourses[input] += quantity;

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string,int> keyValuePair in resourses)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] command = input.Split();

                switch (command[0])
                {
                    case "Add": num.Add(int.Parse(command[1])); break;
                    case "Remove": num.Remove(int.Parse(command[1])); break;
                    case "RemoveAt": num.RemoveAt(int.Parse(command[1])); break;
                    case "Insert": num.Insert(int.Parse(command[2]), int.Parse(command[1])); break;
                }
            }

            Console.WriteLine(String.Join(' ', num));
        }
    }
}
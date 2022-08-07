using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();
            bool isChanged = false;

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
                    case "Add":
                        num.Add(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "Remove":
                        num.Remove(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        num.RemoveAt(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "Insert":
                        num.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "Contains":
                        Console.WriteLine(num.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        PrintEven(num);
                        break;
                    case "PrintOdd":
                        PrintOdd(num);
                        break;
                    case "GetSum":
                        Console.WriteLine(num.Sum());
                        break;
                    case "Filter":
                        Filter(num, command[1], int.Parse(command[2]));
                        break;
                }
            }
            if (isChanged)
            {
                Console.WriteLine(String.Join(' ', num));
            }
        }

        static void Filter(List<int> num, string condition, int n)
        {
            foreach (int i in num)
            {
                switch (condition)
                {
                    case "<":
                        if (i < n)
                        {
                            Console.Write($"{i} ");
                        }
                        break;
                    case ">":
                        if (i > n)
                        {
                            Console.Write($"{i} ");
                        }
                        break;
                    case ">=":
                        if (i >= n)
                        {
                            Console.Write($"{i} ");
                        }
                        break;
                    case "<=":
                        if (i <= n)
                        {
                            Console.Write($"{i} ");
                        }
                        break;
                }
            }
            Console.WriteLine();
        }

        static void PrintOdd(List<int> num)
        {
            foreach (int i in num)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        static void PrintEven(List<int> num)
        {
            foreach (int i in num)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
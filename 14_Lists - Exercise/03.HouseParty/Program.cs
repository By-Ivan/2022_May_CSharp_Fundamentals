using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];

                if (input.Length > 3)
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
            }
            Console.WriteLine(String.Join("\n", guestList));
        }
    }
}

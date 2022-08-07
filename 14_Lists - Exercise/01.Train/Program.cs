using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Add")
                {
                    wagon.Add(int.Parse(command[1]));
                }
                else
                {
                    int passengers = int.Parse(command[0]);
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if (wagon[i] + passengers <= wagonCapacity)
                        {
                            wagon[i] += passengers;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', wagon));
        }
    }
}

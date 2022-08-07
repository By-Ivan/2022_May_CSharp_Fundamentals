using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int element = int.Parse(command[1]);

                switch (command[0])
                {
                    case "Delete":
                        num.RemoveAll(n => n == element);
                        break;
                    case "Insert":
                        int position = int.Parse(command[2]);
                        num.Insert(position, element);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', num));
        }
    }
}

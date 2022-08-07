using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int number = 0;
                int index = 0;

                switch (command[0])
                {
                    case "Add":
                        number = int.Parse(command[1]);
                        num.Add(number);
                        break;
                    case "Insert":
                        number = int.Parse(command[1]);
                        index = int.Parse(command[2]);
                        if (index < 0 || index > num.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {

                            num.Insert(index, number);
                        }
                        break;
                    case "Remove":
                        index = int.Parse(command[1]);
                        if (index < 0 || index > num.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            num.RemoveAt(index);
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(command[2]);
                        if (command[1] == "left")
                        {
                            ShiftLeft(num, count);
                        }
                        else if (command[1] == "right")
                        {
                            ShiftRight(num, count);
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', num));
        }

        private static void ShiftRight(List<int> num, int count)
        {
            for (int i = 0; i < count; i++)
            {
                num.Insert(0, num[num.Count - 1]);
                num.RemoveAt(num.Count - 1);
            }
        }

        static void ShiftLeft(List<int> num, int count)
        {
            for (int i = 0; i < count; i++)
            {
                num.Add(num[0]);
                num.RemoveAt(0);
            }
        }
    }
}

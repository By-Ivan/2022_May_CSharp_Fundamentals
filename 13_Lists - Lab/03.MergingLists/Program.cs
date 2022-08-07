using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            List<int> list1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            List<int> list2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> resultList = new List<int>();
            Console.ResetColor();

            for (int i = 0; i <= Math.Min(list1.Count, list2.Count); i++)
            {
                resultList.Add(list1[0]);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(list1[0] + " ");

                list1.RemoveAt(0);
                resultList.Add(list2[0]);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(list2[0] + " ");

                list2.RemoveAt(0);
                i = 0;
            }

            Console.ForegroundColor = list1.Count > 0 ? ConsoleColor.Red : ConsoleColor.Green;

            Console.Write(String.Join(' ', list1.Count > 0 ? list1 : list2));
            Console.ResetColor();
        }
    }
}

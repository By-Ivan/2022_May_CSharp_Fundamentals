using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> result = new List<int>();

            while (list1.Count > 0 && list2.Count > 0)
            {
                result.Add(list1[0]);
                list1.RemoveAt(0);
                result.Add(list2[list2.Count - 1]);
                list2.RemoveAt(list2.Count - 1);
            }

            int lower = list1.Count > 0 ? list1.Min() : list2.Min();
            int upper = list1.Count > 0 ? list1.Max() : list2.Max();
            result.RemoveAll(n => n <= lower || n >= upper);
            result.Sort();
            Console.WriteLine(String.Join(' ', result));
        }
    }
}

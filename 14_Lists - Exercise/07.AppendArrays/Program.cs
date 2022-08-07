using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split('|').ToList();
            List<int> output = new List<int>();

            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                int[] arr = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    output.Add(arr[j]);
                }
            }
            Console.WriteLine(String.Join(' ', output));
        }
    }
}

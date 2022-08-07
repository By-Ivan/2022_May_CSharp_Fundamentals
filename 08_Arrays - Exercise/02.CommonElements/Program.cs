using System;
using System.Linq;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split().Select(s => s.Trim()).ToArray();
            string[] line2 = Console.ReadLine().Split().Select(s => s.Trim()).ToArray();
            for (int i = 0; i < line2.Length; i++)
            {
                if (line1.Contains(line2[i]))
                {
                    Console.Write($"{line2[i]} ");
                }
            }
        }
    }
}

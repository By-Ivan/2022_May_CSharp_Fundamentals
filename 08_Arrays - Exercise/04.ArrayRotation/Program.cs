using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string tempE = input[0];

                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                  
                }
                input[input.Length - 1] = tempE;
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

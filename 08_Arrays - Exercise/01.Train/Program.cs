using System;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagon = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                wagon[i] = int.Parse(Console.ReadLine());
                sum += wagon[i];
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{wagon[j]} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Linq;

namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < n || n > 60)
            {
                return;
            }
            long[,] pascal = new long[n + 1, n + 1];
            for (int i = 1; i <= n; i++)
            {
                pascal[i, 1] = 1;
            }
            pascal[2, 2] = 1;
            for (int row = 3; row <= n; row++)
            {
                for (int col = 2; col <= row; col++)
                {
                    pascal[row, col] = pascal[row - 1, col] + pascal[row - 1, col - 1];
                }
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == 1 || j == i)
                    {
                        Console.Write($"{pascal[i, j]}");
                    }
                    else
                    {
                        Console.Write($"{pascal[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

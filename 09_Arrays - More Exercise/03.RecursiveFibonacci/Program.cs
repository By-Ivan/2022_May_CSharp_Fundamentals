using System;
using System.Linq;

namespace _03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 50)
            {
                return;
            }
            long[] number = new long[n+1];
            number[1] = 1;
            number[2] = 1;
            for (int i = 3; i <= n; i++)
            {
                number[i] = number[i-1] + number[i-2];
            }
            Console.WriteLine(number[n]);
        }
    }
}

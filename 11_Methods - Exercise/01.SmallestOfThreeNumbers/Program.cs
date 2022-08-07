using System;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestOfThreeNumbers(a, b, c));
        }

        static int SmallestOfThreeNumbers(int a, int b, int c)
        {
            int smallest = int.MaxValue;
            if (a < smallest)
            {
                smallest = a;
            }
            if (b < smallest)
            {
                smallest = b;
            }
            if (c < smallest)
            {
                smallest = c;
            }
            return smallest;
        }
    }
}

using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SubstractThirdFromResult(n1, n2, n3));
        }

        static int SubstractThirdFromResult(int n1, int n2, int n3)
        {
            return SumOfFirstTwoIntegers(n1, n2) - n3;
        }

        static int SumOfFirstTwoIntegers(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}

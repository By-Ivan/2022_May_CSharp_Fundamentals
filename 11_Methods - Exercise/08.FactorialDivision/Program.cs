using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            double[] result = CalculateFactoriel(n1, n2);

            Console.WriteLine($"{result[0] / result[1]:f2}");
        }

        static double[] CalculateFactoriel(int n1, int n2)
        {
            double[] factoriel = { 1, 1 };

            if (n1 != 0 && n1 != 1)
            {
                for (int i = n1; i > 1; i--)
                {
                    factoriel[0] *= i;
                }
            }

            if (n2 != 0 && n2 != 1)
            {
                for (int i = n2; i > 1; i--)
                {
                    factoriel[1] *= i;
                }
            }

            return factoriel;
        }
    }
}

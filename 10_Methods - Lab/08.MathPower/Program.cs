using System;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nBase = double.Parse(Console.ReadLine());
            int nPower = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(nBase, nPower));
        }

        static double RaiseToPower(double nBase, int nPower)
        {
            double result = Math.Pow(nBase, nPower);
            return result;
        }
    }
}

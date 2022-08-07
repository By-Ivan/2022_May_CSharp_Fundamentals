using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                bool isSpecial = false;
                int sum = 0;
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    sum += i.ToString()[j] - '0';
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}

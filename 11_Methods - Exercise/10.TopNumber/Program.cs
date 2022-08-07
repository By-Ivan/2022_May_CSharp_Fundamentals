using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintTopNumber(i);
            }
        }

        static void PrintTopNumber(int n)
        {
            bool condition1 = CheckCondition1(n);
            bool condition2 = CheckCondition2(n);
            if (condition1 && condition2)
            {
                Console.WriteLine(n);
            }

            return;
        }

        static bool CheckCondition1(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;
            }

            return sum % 8 == 0;
        }
        static bool CheckCondition2(int n)
        {
            int countOddDigits = 0;
            while (n > 0)
            {
                int digit = n % 10;
                if (digit % 2 != 0)
                {
                    countOddDigits++;
                }
                n /= 10;
            }

            return countOddDigits > 0;
        }
    }
}

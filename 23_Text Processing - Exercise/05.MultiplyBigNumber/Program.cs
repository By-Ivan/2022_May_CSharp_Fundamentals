using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int digit = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            int remainder = 0;

            if (digit == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                string local = (((bigNumber[i] - '0') * digit) + remainder).ToString();
                remainder = local.Length > 1 ? local[0] - '0' : 0;
                local = i == 0 ? local : local.Substring(local.Length - 1, 1);
                result.Insert(0, local);
            }

            Console.WriteLine(result);
        }
    }
}

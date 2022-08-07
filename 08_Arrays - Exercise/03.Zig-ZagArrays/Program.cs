using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] result = new string[2];
            for (int i = 1; i <= n; i++)
            {
                string[] num = Console.ReadLine().Split().ToArray();
                if (i % 2 == 1)
                {
                    result[0] += num[0] + " ";
                    result[1] += num[1] + " ";
                }
                else if (i % 2 == 0)
                {
                    result[1] += num[0] + " ";
                    result[0] += num[1] + " ";
                }
            }
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
    }
}

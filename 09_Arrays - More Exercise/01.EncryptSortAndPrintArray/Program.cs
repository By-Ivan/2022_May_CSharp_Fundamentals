using System;
using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] encryption = new int[n]; 
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                for (int j = 0; j < name.Length; j++)
                {
                    if ("aeiouAEIOU".IndexOf(name[j]) >= 0)
                    {
                        encryption[i] += name[j] * name.Length;
                    }
                    else
                    {
                        encryption[i] += name[j] / name.Length;
                    }
                }
            }
            var output = from num in encryption orderby num select num;
            foreach (int i in output)
            {
                Console.Write(i + " \n");
            }
        }
    }
}

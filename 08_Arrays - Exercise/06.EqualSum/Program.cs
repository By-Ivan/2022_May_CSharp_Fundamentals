using System;
using System.Linq;
using System.Text;

namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = false;
            int position = 0;
            if (n.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < n.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                if (i == 0)
                {
                    for (int j = 1; j < n.Length; j++)
                    {
                        sumRight += n[j];
                    }
                    sumLeft = n[0];
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        sumLeft += n[j];
                    }
                    for (int j = i + 1; j < n.Length; j++)
                    {
                        sumRight += n[j];
                    }
                }
                if (sumLeft == sumRight)
                {
                    isEqual = true;
                    position = i;
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine(position);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

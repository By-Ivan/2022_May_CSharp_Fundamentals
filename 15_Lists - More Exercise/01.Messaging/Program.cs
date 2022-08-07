using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<char> input = Console.ReadLine().ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int index = DigitSum(numbers[i]);

                if (index >= input.Count)
                {
                    while (index >= input.Count)
                    {
                        index -= input.Count;
                    }
                    Console.Write(input[index]);
                    input.RemoveAt(index);

                }
                else
                {
                    Console.Write(input[index]);
                    input.RemoveAt(index);
                }


            }
        }

        static int DigitSum(string n) => n.Sum(c => c - '0');
    }
}

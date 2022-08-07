using System;
using System.Text;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
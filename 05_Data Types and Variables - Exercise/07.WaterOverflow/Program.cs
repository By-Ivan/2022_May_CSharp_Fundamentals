using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                if (m <= capacity)
                {
                    capacity -= m;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(255-capacity);
        }
    }
}

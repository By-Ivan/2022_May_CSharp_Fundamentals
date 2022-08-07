using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Math.Ceiling((double)int.Parse(Console.ReadLine()) / int.Parse(Console.ReadLine())));
        }
    }
}

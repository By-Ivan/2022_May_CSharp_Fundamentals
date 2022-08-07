using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double timeLeft = 0;
            double timeRight = 0;

            for (int i = 0; i < num.Count / 2; i++)
            {
                timeLeft += num[i];
                timeLeft = num[i] == 0 && timeLeft > 0 ? timeLeft * 0.8 : timeLeft;
            }

            for (int i = num.Count - 1; i > num.Count / 2; i--)
            {
                timeRight += num[i];
                timeRight = num[i] == 0 && timeRight > 0 ? timeRight * 0.8 : timeRight;

            }

            if (timeLeft < timeRight)
            {
                Console.WriteLine($"The winner is left with total time: {timeLeft}");
            }
            else if (timeLeft > timeRight)
            {
                Console.WriteLine($"The winner is right with total time: {timeRight,1}");
            }
        }
    }
}

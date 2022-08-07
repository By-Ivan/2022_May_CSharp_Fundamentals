using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int day = 0;
            int totalYield = 0;
            while (yield >= 100)
            {
                totalYield += yield;
                totalYield -= 26;
                day++;
                yield -= 10;
            }
            if (totalYield >= 26)
            {
                totalYield -= 26;
            }
            Console.WriteLine(day);
            Console.WriteLine(totalYield);
        }
    }
}

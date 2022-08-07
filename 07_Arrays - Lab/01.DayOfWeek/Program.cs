using System;

namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] day = {
             "Monday",
             "Tuesday",
             "Wednesday",
             "Thursday",
             "Friday",
             "Saturday",
             "Sunday",
            };
            int n = int.Parse(Console.ReadLine());
            if (n > 0 && n <= day.Length)
            {
                Console.WriteLine(day[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}

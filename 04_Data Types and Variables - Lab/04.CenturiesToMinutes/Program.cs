using System;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            int y = c * 100;
            int d = (int)(y * 365.2422);
            long h = (long)d * 24;
            long m = (long)h * 60;
            Console.WriteLine($"{c} centuries = {y} years = {d} days = {h} hours = {m} minutes");
        }
    }
}

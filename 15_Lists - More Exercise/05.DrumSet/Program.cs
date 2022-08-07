using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> initialQuality = new List<int>();
            drumSet.ForEach(n => initialQuality.Add(n));
            string input = Console.ReadLine();
            int index = 0;

            while (input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                while (savings >= 0 && index < drumSet.Count)
                {
                    drumSet[index] -= hitPower;
                    int count = drumSet.Count;
                    savings = drumSet[index] <= 0 ? BuyDrumSet(drumSet, initialQuality, index, savings) : savings;
                    index = count == drumSet.Count ? index += 1 : index;
                }
                index = 0;
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");

        }

        static double BuyDrumSet(List<int> drumSet, List<int> initialQuality, int index, double savings)
        {
            if (savings >= initialQuality[index] * 3)
            {
                drumSet[index] = initialQuality[index];
                savings -= initialQuality[index] * 3;
            }
            else
            {
                drumSet.RemoveAt(index);
                initialQuality.RemoveAt(index);
            }

            return savings;
        }
    }
}

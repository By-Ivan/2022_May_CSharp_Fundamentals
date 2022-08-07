using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> hand1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> hand2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (hand1.Count != 0 && hand2.Count != 0)
            {
                if (hand1[0] > hand2[0])
                {
                    hand1.Add(hand1[0]);
                    hand1.Add(hand2[0]);
                    hand1.RemoveAt(0);
                    hand2.RemoveAt(0);
                }
                else if (hand1[0] < hand2[0])
                {
                    hand2.Add(hand2[0]);
                    hand2.Add(hand1[0]);
                    hand1.RemoveAt(0);
                    hand2.RemoveAt(0);
                }
                else if (hand1[0] == hand2[0])
                {
                    hand1.RemoveAt(0);
                    hand2.RemoveAt(0);
                }
            }
            if (hand1.Count != 0)
            {
                Console.WriteLine($"First player wins! Sum: {hand1.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {hand2.Sum()}");
            }
        }
    }
}

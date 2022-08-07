using System;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            CharacterMultiplier(input[0], input[1]);
        }

        private static void CharacterMultiplier(string string1, string string2)
        {
            int sum = 0;

            while (string1.Length > 0 && string2.Length > 0)
            {
                sum += string1[0] * string2[0];
                string1 = string1.Remove(0, 1);
                string2 = string2.Remove(0, 1);
            }

            string remainingString = string1.Length > 0 ? string1 : string2;

            for (int i = 0; i < remainingString.Length; i++)
            {
                sum += remainingString[i];
            }

            Console.WriteLine(sum);
        }
    }
}

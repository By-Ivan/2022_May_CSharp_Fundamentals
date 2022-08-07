using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> leaderboard = new Dictionary<string, int>();
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string participant in participants)
            {
                leaderboard.Add(participant, 0);
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                FillLeaderboard(leaderboard, input);

                input = Console.ReadLine();
            }

            List<string> top3racers = leaderboard.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            Console.WriteLine($"1st place: {top3racers[0]}");
            Console.WriteLine($"2nd place: {top3racers[1]}");
            Console.WriteLine($"3rd place: {top3racers[2]}");
        }

        private static void FillLeaderboard(Dictionary<string, int> leaderboard, string input)
        {
            Regex regName = new Regex(@"[A-Za-z]");
            MatchCollection matchName = regName.Matches(input);
            string name = string.Join("", matchName);

            Regex regDistance = new Regex(@"\d");
            MatchCollection matchDistance = regDistance.Matches(input);
            int distance = 0;

            foreach (Match digit in matchDistance)
            {
                distance += int.Parse(digit.Value);
            }

            if (leaderboard.ContainsKey(name))
            {
                leaderboard[name] += distance;
            }
        }
    }
}

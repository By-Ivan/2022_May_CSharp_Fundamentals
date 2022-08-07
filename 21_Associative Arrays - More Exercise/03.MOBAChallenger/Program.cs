using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            string input = Console.ReadLine();

            while (input != "Season end")
            {
                if (input.Contains(" -> "))
                {
                    string[] cmd = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    AddPlayer(players, cmd[0], cmd[1], int.Parse(cmd[2]));
                }
                else if (input.Contains(" vs "))
                {
                    string[] cmd = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);

                    DuelPlayers(players, cmd[0], cmd[1]);
                }

                input = Console.ReadLine();
            }

            PrintResults(players);
        }

        private static void PrintResults(List<Player> players)
        {
            List<Player> resultPlayers = players.OrderByDescending(x => x.Positions.Values.Sum()).ThenBy(x => x.Name).ToList();

            foreach (Player player in resultPlayers)
            {
                Console.WriteLine($"{player.Name}: {player.Positions.Values.Sum()} skill");

                var resultPositions = player.Positions.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

                foreach (KeyValuePair<string, int> keyValuePair in resultPositions)
                {
                    Console.WriteLine($"- {keyValuePair.Key} <::> {keyValuePair.Value}");
                }
            }
        }

        private static void DuelPlayers(List<Player> players, string player1, string player2)
        {
            if (players.Select(x => x.Name).ToList().Contains(player1)
                && players.Select(x => x.Name).ToList().Contains(player2))
            {
                Player fighter1 = players.FirstOrDefault(x => x.Name == player1);
                Player fighter2 = players.FirstOrDefault(x => x.Name == player2);

                bool fight = false;

                foreach (string position1 in fighter1.Positions.Keys)
                {
                    foreach (string position2 in fighter2.Positions.Keys)
                    {
                        if (position1 == position2)
                        {
                            fight = true;
                        }
                    }
                }

                if (fight)
                {
                    if (fighter1.Positions.Values.Sum() > fighter2.Positions.Values.Sum())
                    {
                        players.Remove(fighter2);
                    }
                    else if (fighter1.Positions.Values.Sum() < fighter2.Positions.Values.Sum())
                    {
                        players.Remove(fighter1);
                    }
                }
            }
        }

        private static void AddPlayer(List<Player> players, string playerName, string playerPosition, int playerSkill)
        {
            if (!players.Select(x => x.Name).ToList().Contains(playerName))
            {
                players.Add(new Player(playerName, playerPosition, playerSkill));
            }
            else
            {
                int index = players.FindIndex(x => x.Name == playerName);

                if (!players[index].Positions.ContainsKey(playerPosition))
                {
                    players[index].Positions.Add(playerPosition, playerSkill);
                }
                else
                {
                    if (players[index].Positions.First(x => x.Key == playerPosition).Value < playerSkill)
                    {
                        players[index].Positions[playerPosition] = playerSkill;
                    }
                }
            }
        }
    }
    class Player
    {
        public Player(string name, string position, int skill)
        {
            Name = name;
            Positions = new Dictionary<string, int>();
            Positions.Add(position, skill);
        }

        public string Name { get; set; }
        public Dictionary<string, int> Positions { get; set; }
    }
}
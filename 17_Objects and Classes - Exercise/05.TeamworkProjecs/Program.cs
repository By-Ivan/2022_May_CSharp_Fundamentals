using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.TeamworkProjecs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] teamInfo = Console.ReadLine().Split('-',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string teamCreator = teamInfo[0];
                string teamName = teamInfo[1];

                Team team = new Team(teamName, teamCreator);

                if (teams.Exists(x=> x.Name == team.Name))
                {
                    Console.WriteLine($"Team {team.Name} was already created!");
                }
                else if (teams.Exists(x => x.Creator == team.Creator))
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                }
                else
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                }
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] memberInfo = input.Split("->",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string memberName = memberInfo[0];
                string memberTeam = memberInfo[1];

                if (!teams.Exists(x => x.Name == memberTeam))
                {
                    Console.WriteLine($"Team {memberTeam} does not exist!");
                }
                else
                {
                    if (teams.Select(x => x.Members).Any(x => x.Contains(memberName)) 
                        || teams.Select(x => x.Creator).Contains(memberName))
                    {
                        Console.WriteLine($"Member {memberName} cannot join team {memberTeam}!");
                    }
                    else
                    {
                        int index = teams.FindIndex(x => x.Name == memberTeam);
                        teams[index].Members.Add(memberName);
                    }
                }

                input = Console.ReadLine();
            }

            List<Team> disbandedTeams = teams.OrderBy(x => x.Name).Where(x => x.Members.Count == 0).ToList();
            List<Team> validTeams = teams.
                        OrderByDescending(x => x.Members.Count).
                        ThenBy(x => x.Name).
                        Where(x => x.Members.Count > 0).ToList();

            foreach (Team team in validTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine($"Teams to disband:");
            if (disbandedTeams.Count > 0)
            {
                foreach (Team team in disbandedTeams)
                {
                    Console.WriteLine($"{team.Name}");
                }
            }
        }
    }

    class Team
    {

        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}
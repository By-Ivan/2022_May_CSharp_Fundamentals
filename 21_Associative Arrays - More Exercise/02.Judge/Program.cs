using System;
using System.Linq;
using System.Collections.Generic;

namespace _2.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Student>> contests = new Dictionary<string, List<Student>>();

            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] cmd = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                ContestsRunning(contests, cmd);

                input = Console.ReadLine();
            }

            PrintResults(contests);
        }

        private static void ContestsRunning(Dictionary<string, List<Student>> contests, string[] cmd)
        {
            string userName = cmd[0];
            string contestName = cmd[1];
            int points = int.Parse(cmd[2]);

            Student student = new Student(userName, points);

            if (!contests.Select(x => x.Key).ToList().Contains(contestName))
            {
                contests.Add(contestName, new List<Student>());
                contests[contestName].Add(student);
            }
            else
            {
                if (contests[contestName].Select(x => x.Username).ToList().Contains(userName))
                {
                    int index = contests[contestName].FindIndex(x => x.Username == userName);

                    if (points > contests[contestName][index].Points)
                    {
                        contests[contestName][index].Points = points;
                    }
                }
                else
                {
                    contests[contestName].Add(student);
                }
            }
        }

        private static void PrintResults(Dictionary<string, List<Student>> contests)
        {
            List<Student> students = new List<Student>();

            foreach (KeyValuePair<string, List<Student>> keyValuePair in contests)
            {
                List<Student> result = keyValuePair.Value.OrderByDescending(x => x.Points).ThenBy(x => x.Username).ToList();

                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value.Count} participants");

                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {result[i].Username} <::> {result[i].Points}");

                    if (!students.Select(x => x.Username).ToList().Contains(result[i].Username))
                    {
                        students.Add(result[i]);
                    }
                    else
                    {
                        int index = students.FindIndex(x => x.Username == result[i].Username);
                        students[index].Points += result[i].Points;
                    }
                }
            }

            Console.WriteLine("Individual standings:");

            List<Student> individualStandings = students.OrderByDescending(x => x.Points).ThenBy(x => x.Username).ToList();

            for (int i = 0; i < individualStandings.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {individualStandings[i].Username} -> {individualStandings[i].Points}");
            }
        }

        class Student
        {
            public Student(string username, int points)
            {
                Username = username;
                Points = points;
            }

            public string Username { get; set; }
            public int Points { get; set; }

        }
    }
}

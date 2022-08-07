using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Ranking
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> students = new SortedDictionary<string, Dictionary<string, int>>();
            Dictionary<string, string> courses = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] cmd = input.Split(':', StringSplitOptions.RemoveEmptyEntries);

                if (!courses.ContainsKey(cmd[0]))
                {
                    courses.Add(cmd[0], string.Empty);
                }

                courses[cmd[0]] = cmd[1];
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] cmd = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = cmd[0];
                string password = cmd[1];
                string username = cmd[2];
                int points = int.Parse(cmd[3]);

                if (courses.ContainsKey(contest))
                {
                    if (courses[contest] == password)
                    {
                        if (!students.ContainsKey(username))
                        {
                            students.Add(username, new Dictionary<string, int>());
                            students[username].Add(contest, points);
                        }
                        else
                        {
                            if (!students[username].ContainsKey(contest))
                            {
                                students[username].Add(contest, points);
                            }
                            else
                            {
                                students[username][contest] = points > students[username][contest] ? points : students[username][contest];
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            int maxSum = int.MinValue;
            string user = string.Empty;

            foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair in students)
            {
                int sum = keyValuePair.Value.Values.Sum();

                if (maxSum < sum)
                {
                    maxSum = sum;
                    user = keyValuePair.Key;
                }
            }

            Console.WriteLine($"Best candidate is {user} with total {maxSum} points.");
            Console.WriteLine("Ranking:");

            foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair in students)
            {
                Console.WriteLine($"{keyValuePair.Key}");

                var result = keyValuePair.Value.OrderByDescending(x => x.Value);

                foreach (KeyValuePair<string, int> course in result)
                {
                    Console.WriteLine($"#  {course.Key} -> {course.Value}");
                }
            }
        }
    }
}
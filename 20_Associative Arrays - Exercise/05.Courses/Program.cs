using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmd = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = cmd[0];
                string student = cmd[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }

                courses[course].Add(student);

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> keyValuePair in courses)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value.Count}");

                foreach (string s in keyValuePair.Value)
                {
                    Console.WriteLine($"-- {s}");
                }
            }
        }
    }
}

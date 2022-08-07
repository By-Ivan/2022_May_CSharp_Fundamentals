using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmd = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = cmd[0];
                string employeeId = cmd[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employeeId);
                }
                else if (!companies[companyName].Contains(employeeId))
                {
                    companies[companyName].Add(employeeId);
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> keyValuePair in companies)
            {
                Console.WriteLine($"{keyValuePair.Key}");

                foreach (string employeeId in keyValuePair.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}

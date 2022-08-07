using System;
using System.Collections.Generic;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> validated = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string username = cmd[1];

                switch (cmd[0])
                {
                    case "register":
                        string licensePlate = cmd[2];

                        if (!validated.ContainsKey(username))
                        {
                            validated.Add(username, licensePlate);
                            Console.WriteLine($"{username} registered {licensePlate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {validated[username]}");
                        }
                        break;
                    case "unregister":
                        if (!validated.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            validated.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (KeyValuePair<string, string> keyValuePair in validated)
            {
                Console.WriteLine($"{keyValuePair.Key} => {keyValuePair.Value}");
            }
        }
    }
}

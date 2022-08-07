using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = DecryptMessage(Console.ReadLine());

                Regex regex = new Regex(@"@(?<planet>[A-Z]*[a-z]*)[^\-@!:>]*:(?<population>\d+)[^\-@!:>]*!(?<type>[A|D])![^\-@!:>]*->(?<soldiers>\d+)");

                if (regex.IsMatch(input))
                {
                    string planet = regex.Match(input).Groups["planet"].Value;
                    int population = int.Parse(regex.Match(input).Groups["population"].Value);
                    string attackType = regex.Match(input).Groups["type"].Value;
                    int soldiers = int.Parse(regex.Match(input).Groups["soldiers"].Value);

                    switch (attackType)
                    {
                        case "A":
                            attackedPlanets.Add(planet);
                            break;
                        case "D":
                            destroyedPlanets.Add(planet);
                            break;
                    }
                }

            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (string planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (string planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        static string DecryptMessage(string input)
        {
            StringBuilder message = new StringBuilder();
            Regex regKey = new Regex(@"(?<key>[s,t,a,r,S,T,A,R])");
            int key = regKey.Matches(input).Count;

            for (int j = 0; j < input.Length; j++)
            {
                message.Append((char)(input[j] - key));
            }

            return message.ToString();
        }
    }
}

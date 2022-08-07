using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> demons = Console.ReadLine().Split(',').OrderBy(x => x).ToList();

            for (int i = 0; i < demons.Count; i++)
            {
                string demon = demons[i].Trim();

                if (!demon.Contains(' ') && !demon.Equals(""))
                {
                    Regex regHealth = new Regex(@"[^\+\-*/\d\.]");
                    int health = regHealth.Matches(demon).ToList().Sum(x => char.Parse(x.Value));

                    Regex regDamage = new Regex(@"\-?\d+\.?\d*");
                    double damage = regDamage.Matches(demon).Sum(x => double.Parse(x.Value));
                    regDamage = new Regex(@"(\*|/)");
                    MatchCollection operations = regDamage.Matches(demon);

                    foreach (string operation in operations.Select(x => x.Value))
                    {
                        damage = operation == "*" ? damage * 2 : damage / 2;
                    }

                    Console.WriteLine($"{demon} - {health} health, {damage:f2} damage");
                }
                else
                {
                    demons.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}

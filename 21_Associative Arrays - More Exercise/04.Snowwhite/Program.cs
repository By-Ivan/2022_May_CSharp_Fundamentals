using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarves = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                string[] cmd = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string dwarfName = cmd[0];
                string dwarfHatColor = cmd[1];
                int dwarfPhysics = int.Parse(cmd[2]);

                string dwarfID = dwarfName + '-' + dwarfHatColor;

                if (!dwarves.ContainsKey(dwarfID))
                {
                    dwarves.Add(dwarfID, dwarfPhysics);
                }
                else
                {
                    dwarves[dwarfID] = Math.Max(dwarves[dwarfID], dwarfPhysics);
                }

                input = Console.ReadLine();
            }

            foreach (var dwarf in dwarves
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarves.Where(y => y.Key.Split('-')[1] == x.Key.Split('-')[1]).Count()))
            {
                Console.WriteLine($"({dwarf.Key.Split('-')[1]}) {dwarf.Key.Split('-')[0]} <-> {dwarf.Value}");
            }
        }
    }
}

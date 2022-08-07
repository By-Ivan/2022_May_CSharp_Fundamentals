using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.DragonArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = cmd[0];
                string name = cmd[1];
                int damage = cmd[2] == "null" ? -1 : int.Parse(cmd[2]);
                int health = cmd[3] == "null" ? -1 : int.Parse(cmd[3]);
                int armor = cmd[4] == "null" ? -1 : int.Parse(cmd[4]);

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new List<Dragon>());
                    dragons[type].Add(new Dragon(name, damage, health, armor));
                }
                else
                {
                    if (dragons[type].Select(x => x.Name).Contains(name))
                    {
                        int index = dragons[type].FindIndex(x => x.Name == name);

                        dragons[type].RemoveAt(index);
                        dragons[type].Insert(index, new Dragon(name, damage, health, armor));
                    }
                    else
                    {
                        dragons[type].Add(new Dragon(name, damage, health, armor));
                    }
                }
            }

            foreach (KeyValuePair<string, List<Dragon>> keyValuePair in dragons)
            {
                var result = keyValuePair.Value.OrderBy(x => x.Name);

                Console.WriteLine($"{keyValuePair.Key}::({result.Average(x => x.Damage):f2}/{result.Average(x => x.Health):f2}/{result.Average(x => x.Armor):f2})");

                foreach (Dragon dragon in result)
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }

    class Dragon
    {
        public Dragon(string name, int damage, int health, int armor)
        {
            Name = name;
            AddDragon(damage, health, armor);
        }
        public string Name { get; set; }
        public int Health { get; set; } = 250;
        public int Damage { get; set; } = 45;
        public int Armor { get; set; } = 10;

        public void AddDragon(int damage, int health, int armor)
        {
            this.Damage = damage != -1 ? damage : this.Damage;

            this.Health = health != -1 ? health : this.Health;

            this.Armor = armor != -1 ? armor : this.Armor;
        }
    }
}

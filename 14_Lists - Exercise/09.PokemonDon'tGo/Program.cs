using System;
using System.Linq;
using System.Collections.Generic;

namespace _09.PokemonDontGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> distance = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int sum = 0;

            while (distance.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int n = 0;
                int logicCase = -1;

                if (index < 0)
                {
                    n = 0;
                    logicCase = 1;
                }
                else if (index >= distance.Count)
                {
                    n = distance.Count - 1;
                    logicCase = 2;
                }
                else
                {
                    n = index;
                }

                for (int i = 0; i < distance.Count; i++)
                {
                    if (i == n)
                    {
                        continue;
                    }
                    else if (distance[i] <= distance[n])
                    {
                        distance[i] += distance[n];
                    }
                    else if (distance[i] > distance[n])
                    {
                        distance[i] -= distance[n];
                    }
                }

                sum += distance[n];
                distance.RemoveAt(n);

                if (logicCase == 1)
                {
                    distance.Insert(0, distance[distance.Count - 1]);
                }
                else if (logicCase == 2)
                {
                    distance.Add(distance[0]);
                }
            }
            Console.WriteLine(sum);
        }
    }
}

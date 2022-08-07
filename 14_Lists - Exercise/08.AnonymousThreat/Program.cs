using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "merge":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        Merge(inputLine, startIndex, endIndex);
                        break;

                    case "divide":
                        int index = int.Parse(command[1]);
                        int partitions = int.Parse(command[2]);
                        Divide(inputLine, index, partitions);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', inputLine));
        }
        static void Merge(List<string> inputLine, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }
            startIndex = startIndex < 0 ? 0 : startIndex;
            endIndex = endIndex >= inputLine.Count ? inputLine.Count - 1 : endIndex;
            int count = endIndex - startIndex;

            while (count > 0)
            {
                inputLine[startIndex] += inputLine[startIndex + 1];
                inputLine.RemoveAt(startIndex + 1);
                count--;
            }
        }

        static void Divide(List<string> inputLine, int index, int partitions)
        {
            if (partitions <= 0)
            {
                return;
            }

            int elementLength = inputLine[index].Length;
            int divisionLength = elementLength / partitions;
            string[] division = new string[partitions];

            for (int i = 0; i < partitions; i++)
            {
                
                if (elementLength % partitions != 0 && i == partitions - 1)
                {
                    division[i] = inputLine[index].Substring(i * divisionLength, elementLength % partitions + divisionLength);
                }
                else
                {
                    division[i] = inputLine[index].Substring(i * divisionLength, divisionLength);
                }
            }

            inputLine.RemoveAt(index);

            for (int i = partitions - 1; i >= 0; i--)
            {
                inputLine.Insert(index, division[i]);
            }
        }

    }
}

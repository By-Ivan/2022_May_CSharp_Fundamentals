using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];
            int[] bugPosition = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < bugPosition.Length; i++)
            {
                if (bugPosition[i] >= 0 && bugPosition[i] < size)
                {
                    field[bugPosition[i]] = 1;
                }
            }
            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input == "end")
                {
                    return;
                }
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int position = int.Parse(command[0]);
                string direction = command[1];
                int steps = int.Parse(command[2]);

                if (steps != 0 && position >= 0 && position < size && field[position] == 1)
                {
                    if (direction == "right")
                    {
                        int newPosition = position + steps;
                        while (newPosition < size && newPosition >= 0)
                        {
                            if (field[newPosition] == 1)
                            {
                                newPosition += steps;
                            }
                            else if (field[newPosition] == 0)
                            {
                                field[newPosition] = 1;
                                break;
                            }
                        }
                        field[position] = 0;
                    }
                    else if (direction == "left")
                    {
                        int newPosition = position - steps;
                        while (newPosition < size && newPosition >= 0)
                        {
                            if (field[newPosition] == 1)
                            {
                                newPosition -= steps;
                            }
                            else if (field[newPosition] == 0)
                            {
                                field[newPosition] = 1;
                                break;
                            }
                        }
                        field[position] = 0;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', field));
        }
    }
}

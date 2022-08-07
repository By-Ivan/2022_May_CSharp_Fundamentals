using System;
using System.Linq;
using System.Text;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command.Length == 2)
                {
                    if (command[0] == "exchange")
                    {
                        Exchange(array, int.Parse(command[1]));
                    }
                    else if (command[0] == "max")
                    {
                        Max(array, command[1]);
                    }
                    else if (command[0] == "min")
                    {
                        Min(array, command[1]);
                    }
                }
                else if (command.Length == 3)
                {
                    if (command[0] == "first")
                    {
                        FirstN(array, int.Parse(command[1]), command[2]);
                    }
                    else if (command[0] == "last")
                    {
                        LastN(array, int.Parse(command[1]), command[2]);
                    }
                }

                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine("[" + String.Join(", ", array) + "]");
        }

        static void Exchange(int[] array, int n)
        {
            if (n < 0 || n > array.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            if (n != array.Length - 1)
            {
                int[] bufferArray = new int[array.Length];
                int indexOffset = array.Length - n - 1;

                for (int i = 0; i < array.Length; i++)
                {
                    bufferArray[i] = array[i];
                }

                for (int i = 0; i < indexOffset; i++)
                {
                    array[i] = bufferArray[i + n + 1];
                }

                for (int i = indexOffset; i < array.Length; i++)
                {
                    array[i] = bufferArray[i - indexOffset];
                }
            }
        }
        static void Max(int[] array, string type)
        {
            int maxNum = int.MinValue;
            int index = -1;

            if (type == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        if (array[i] > maxNum || (array[i] == maxNum && i > index))
                        {
                            maxNum = array[i];
                            index = i;
                        }
                    }
                }
            }
            else if (type == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] > maxNum || (array[i] == maxNum && i > index))
                        {
                            maxNum = array[i];
                            index = i;
                        }
                    }
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void Min(int[] array, string type)
        {
            int minNum = int.MaxValue;
            int index = -1;

            if (type == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        if (array[i] < minNum || (array[i] == minNum && i > index))
                        {
                            minNum = array[i];
                            index = i;
                        }
                    }
                }
            }
            else if (type == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] < minNum || (array[i] == minNum && i > index))
                        {
                            minNum = array[i];
                            index = i;
                        }
                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void FirstN(int[] array, int n, string type)
        {
            if (n > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int[] result = new int[n];

            if (type == "odd")
            {
                int currentIndex = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = currentIndex; j < array.Length; j++)
                    {
                        if (array[j] % 2 != 0)
                        {
                            result[i] = array[j];
                            currentIndex = j + 1;
                            break;
                        }
                    }
                    if (result[i] == 0)
                    {
                        break;
                    }
                }
            }
            else if (type == "even")
            {
                int currentIndex = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = currentIndex; j < array.Length; j++)
                    {
                        if (array[j] % 2 == 0)
                        {
                            if (array[j] == 0)
                            {
                                result[i] = -1;
                                currentIndex = j + 1;
                                break;
                            }
                            else
                            {
                                result[i] = array[j];
                                currentIndex = j + 1;
                                break;
                            }
                        }
                    }
                    if (result[i] == 0)
                    {
                        break;
                    }
                }
            }
            if (result.Sum() == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                int finalResultSize = 0;

                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] > 0 || result[i] == -1)
                    {
                        finalResultSize++;
                    }
                }
                int[] finalResult = new int[finalResultSize];

                for (int i = 0; i < finalResultSize; i++)
                {
                    if (result[i] == -1)
                    {
                        finalResult[i] = 0;
                    }
                    else
                    {
                        finalResult[i] = result[i];
                    }
                }
                Console.WriteLine("[" + String.Join(", ", finalResult) + "]");
            }
        }
        static void LastN(int[] array, int n, string type)
        {
            if (n > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int[] result = new int[n];

            if (type == "odd")
            {
                int currentIndex = array.Length - 1;

                for (int i = n - 1; i >= 0; i--)
                {
                    for (int j = currentIndex; j >= 0; j--)
                    {
                        if (array[j] % 2 != 0)
                        {
                            result[i] = array[j];
                            currentIndex = j - 1;
                            break;
                        }
                    }
                    if (result[i] == 0)
                    {
                        break;
                    }
                }
            }
            else if (type == "even")
            {
                int currentIndex = array.Length - 1;

                for (int i = n - 1; i >= 0; i--)
                {
                    for (int j = currentIndex; j >= 0; j--)
                    {
                        if (array[j] % 2 == 0)
                        {
                            if (array[j] == 0)
                            {
                                result[i] = -1;
                                currentIndex = j + 1;
                                break;
                            }
                            else
                            {
                                result[i] = array[j];
                                currentIndex = j - 1;
                                break;
                            }
                        }
                    }
                    if (result[i] == 0)
                    {
                        break;
                    }
                }
            }
            if (result.Sum() == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                int finalResultSize = 0;

                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] > 0 || result[i] == -1)
                    {
                        finalResultSize++;
                    }
                }
                int[] finalResult = new int[finalResultSize];
                int minusIndex = 0;

                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == 0)
                    {
                        minusIndex++;
                    }
                    else if (result[i] == -1) 
                    {
                        finalResult[i - minusIndex] = 0;
                    }
                    else
                    {
                        finalResult[i - minusIndex] = result[i];
                    }
                }
                Console.WriteLine("[" + String.Join(", ", finalResult) + "]");
            }
        }
    }
}
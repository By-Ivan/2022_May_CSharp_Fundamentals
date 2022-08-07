using System;
using System.Text;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder message = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int offset = ((input[0] - 48) - 2) * 3;
                if (input[0] - 48 == 0)
                {
                    message.Append(" ");
                }
                else
                {
                    if (input[0] - 48 == 8 || input[0] - 48 == 9)
                    {
                        offset++;
                    }
                    int index = offset + input.Length - 1 + 97;
                    message.Append((char)index);
                }
            }
            Console.WriteLine(message.ToString());
        }
    }
}
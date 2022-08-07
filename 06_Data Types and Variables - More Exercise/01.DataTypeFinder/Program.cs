using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while (input != "END")
            {
                if (input == string.Empty)
                {
                    input = Console.ReadLine();
                }

                if (int.TryParse(input, out int result1))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out float result2))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out char result3))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out bool result4))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else 
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}

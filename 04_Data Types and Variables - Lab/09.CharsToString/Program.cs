using System;
using System.Text;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()) };

            string result = new string(chars);
            
            Console.WriteLine(result);
        }
    }
}

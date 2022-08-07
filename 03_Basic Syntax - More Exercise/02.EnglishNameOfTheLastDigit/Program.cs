using System;

namespace _02.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lastDigit(Console.ReadLine()));
        }
        public static string lastDigit(string n)
        {
            string d = n[n.Length - 1].ToString();
            switch (d)
            {
                case "0": d = "zero"; break;
                case "1": d = "one"; break;
                case "2": d = "two"; break;
                case "3": d = "three"; break;
                case "4": d = "four"; break;
                case "5": d = "five"; break;
                case "6": d = "six"; break;
                case "7": d = "seven"; break;
                case "8": d = "eight"; break;
                case "9": d = "nine"; break;
            }
            return d;
        }
    }
}
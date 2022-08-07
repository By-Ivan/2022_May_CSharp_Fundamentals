using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string model = string.Empty;
            string biggestKeg = string.Empty;
            double biggestVolume = 0;
            for (int i = 0; i < n; i++)
            {
                model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentVolume = Math.PI * Math.Pow(radius, 2) * height;
                if (currentVolume > biggestVolume)
                {
                    biggestVolume = currentVolume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}

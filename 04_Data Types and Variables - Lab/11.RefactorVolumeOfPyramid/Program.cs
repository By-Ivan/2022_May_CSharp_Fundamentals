using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            double V = (length * width * h) / 3;
            Console.WriteLine($"Pyramid Volume: {V:f2}");

        }
    }
}

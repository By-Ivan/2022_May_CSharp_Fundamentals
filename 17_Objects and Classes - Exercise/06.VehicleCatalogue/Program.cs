using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] vehicleInfo = input.Split(' ').ToArray();
                catalogue.Add(new Vehicle(vehicleInfo[0], vehicleInfo[1], vehicleInfo[2], int.Parse(vehicleInfo[3])));
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                Vehicle vehicle = catalogue.Find(x => x.Model == input);
                Console.WriteLine($"{vehicle}");
                input = Console.ReadLine();
            }

            double carsAverageHorsepower = 0;
            double trucksAverageHorsepower = 0;

            if (catalogue.Where(x => x.Type == "car").Count() > 0)
            {
                carsAverageHorsepower = catalogue.Where(x => x.Type == "car").Select(x => x.Horsepower).Average();
            }
            if (catalogue.Where(x => x.Type == "truck").Count() > 0)
            {
                trucksAverageHorsepower = catalogue.Where(x => x.Type == "truck").Select(x => x.Horsepower).Average();
            }

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsepower:f2}.");
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
        public override string ToString()
        {
            string output = string.Empty;

            if (this.Type == "car")
            {
                output = $"Type: Car\n";
            }
            else
            {
                output = $"Type: Truck\n";
            }

            output += $"Model: {this.Model}\nColor: {this.Color}\nHorsepower: {this.Horsepower}";

            return output.Trim();
        }
    }
}
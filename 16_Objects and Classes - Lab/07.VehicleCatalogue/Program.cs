using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split('/', StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                string type = command[0];
                string brand = command[1];
                string model = command[2];

                switch (type)
                {
                    case "Car":
                        int horsePower = int.Parse(command[3]);
                        catalogue.Cars.Add(new Car(brand,model,horsePower));
                        break;

                    case "Truck":
                        int weight = int.Parse(command[3]);
                        catalogue.Trucks.Add(new Truck(brand, model, weight));
                        break;
                }

                input = Console.ReadLine();
            }

            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                catalogue.Cars = catalogue.Cars.OrderBy(c => c.Brand).ToList();

                foreach (Car car in catalogue.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                catalogue.Trucks = catalogue.Trucks.OrderBy(c => c.Brand).ToList();

                foreach (Truck truck in catalogue.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Catalogue
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Truck> Trucks { get; set; } = new List<Truck>();
    }
}
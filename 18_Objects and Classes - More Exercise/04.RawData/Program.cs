using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                cars.Add(new Car(carInfo[0], int.Parse(carInfo[1]), int.Parse(carInfo[2]), int.Parse(carInfo[3]), carInfo[4]));
            }

            string input = Console.ReadLine();
            List<string> output = new List<string>();

            switch (input)
            {
                case "fragile":
                    output = cars.
                        Where(x => x.Cargo.CargoWeight < 1000 && x.Cargo.CargoType == "fragile").
                        Select(x => x.Model).ToList();
                    break;
                case "flamable":
                    output = cars.
                        Where(x => x.Engine.EnginePower > 250 && x.Cargo.CargoType == "flamable").
                        Select(x => x.Model).ToList();
                    break;
            }

            Console.WriteLine(String.Join("\n", output));
        }
    }

    class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }

    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
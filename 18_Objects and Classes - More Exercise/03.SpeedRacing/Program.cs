using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.SpeedRacing
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
                Car car = new Car(carInfo[0], int.Parse(carInfo[1]), double.Parse(carInfo[2]));
                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = command[1];
                int distance = int.Parse(command[2]);

                int index = cars.FindIndex(x => x.Model == model);

                if (cars[index].TripPossible(distance))
                {
                    cars[index].DistanceTraveled += distance;
                    cars[index].Fuel -= distance * cars[index].FuelConsumption;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", cars));
        }
    }

    class Car
    {
        public Car(string model, int fuel, double fuelConsumption)
        {
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            DistanceTraveled = 0;
        }

        public string Model { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }
        public int DistanceTraveled { get; set; }
        public override string ToString() => $"{this.Model} {this.Fuel:f2} {this.DistanceTraveled}";

        public bool TripPossible(int distance)
        {
            if (distance * this.FuelConsumption <= this.Fuel)
            {
                return true;
            }
            return false;
        }
    }
}
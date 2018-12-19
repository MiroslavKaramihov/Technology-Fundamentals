using System;
using System.Collections.Generic;
using System.Linq;

namespace p_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> list = new List<Vehicle>();

            while (true)
            {

                string[] splitedInput = Console.ReadLine().Split().ToArray();

                if (splitedInput[0] == "End")
                {
                    break;
                }


                string carOrTruck = splitedInput[0];
                if (carOrTruck == "car")
                {
                    carOrTruck = "Car";
                }
                else
                {
                    carOrTruck = "Truck";
                }
                string model = splitedInput[1];
                string color = splitedInput[2];
                int horsePower = int.Parse(splitedInput[3]);

                Vehicle vehicle = new Vehicle(carOrTruck);

                vehicle.Model = model;
                vehicle.Color = color;
                vehicle.HorsePower = horsePower;

                list.Add(vehicle);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }

                foreach (var item in list)
                {
                    if (item.Model == input)
                    {
                        Console.WriteLine($"Type: {item.CarOrTruck}");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                }

            }
            List<Vehicle> carList = list.Where(x => x.CarOrTruck == "Car").ToList();
            List<Vehicle> trucList = list.Where(x => x.CarOrTruck == "Truck").ToList();

            int carCount = carList.Count;
            double sumHP = carList.Select(x => x.HorsePower).Sum();
            int trucCount = trucList.Count;
            double sumTruckPh = trucList.Select(x => x.HorsePower).Sum();

            if (carCount == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {sumHP / carCount:f2}.");
            }
            if (trucCount == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
            else
            {

                Console.WriteLine($"Trucks have average horsepower of: {sumTruckPh / trucCount:f2}.");

            }

        }
    }

    class Vehicle
    {
        public Vehicle(string carOrTruk)
        {
            CarOrTruck = carOrTruk;
        }

        public string CarOrTruck { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }
}

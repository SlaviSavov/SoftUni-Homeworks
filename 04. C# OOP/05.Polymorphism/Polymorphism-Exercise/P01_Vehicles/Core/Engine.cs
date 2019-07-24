using P01_Vehicles.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_Vehicles.Core
{
    public class Engine
    {
        public Engine()
        {

        }
        public void Run()
        {
            var carInput = Console.ReadLine()
                .Split(" ")
                .ToArray();

            double carFuelQuantity = double.Parse(carInput[1]);
            double carFuelConsumption = double.Parse(carInput[2]);

            Car car = new Car(carFuelQuantity, carFuelConsumption);

            var truckInput = Console.ReadLine()
                .Split(" ")
                .ToArray();

            double truckFuelQuantity = double.Parse(truckInput[1]);
            double truckFuelConsumption = double.Parse(truckInput[2]);

            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                string command = input[0];
                string vehicle = input[1];
                double distanceOrLiters = double.Parse(input[2]);

                if (command == "Drive")
                {
                    if (vehicle == "Car")
                    {
                        if (car.CanDrive(distanceOrLiters))
                        {
                            car.Drive(distanceOrLiters);
                            Console.WriteLine($"Car travelled {distanceOrLiters} km");
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else if (vehicle == "Truck")
                    {
                        if (truck.CanDrive(distanceOrLiters))
                        {
                            truck.Drive(distanceOrLiters);
                            Console.WriteLine($"Truck travelled {distanceOrLiters} km");
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }

                    }
                }
                else if (command == "Refuel")
                {
                    if (vehicle == "Car")
                    {
                        car.Refuel(distanceOrLiters);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Refuel(distanceOrLiters);
                    }

                }


            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }

    }
}

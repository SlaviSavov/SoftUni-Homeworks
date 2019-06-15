using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Speed_Racing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carList = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();
                var model = input[0];
                var fuelAmount = double.Parse(input[1]);
                var fuelConsumption = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);

                carList.Add(car);
            }

            var command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                var token = command
                    .Split()
                    .ToArray();
                var carModel = token[1];
                var distance = double.Parse(token[2]);


                Car car = carList.FirstOrDefault(c => c.Model == carModel);

                car.Drive(distance);
            }

            foreach (var item in carList)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_RawData
{
 public    class Engine
    {
        private List<Car> cars;

        public Engine()
        {
            cars = new List<Car>();
        }
        public void Run()
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine()
                    ?.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Car car = CreateCar(parameters);

                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(x => x.CargoType == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                PrintInfo(fragile);
            }
            else
            {
                List<string> flamable = cars
                    .Where(x => x.CargoType == "flamable" && x.EnginePower > 250)
                    .Select(x => x.Model)
                    .ToList();

                PrintInfo(flamable);
            }

        }

        private void PrintInfo(List<string> cars)
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }

        private Car CreateCar(string[] parameters)
        {
            string model = parameters[0];
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];


            double tire1Pressure = double.Parse(parameters[5]);
            int tire1Age = int.Parse(parameters[6]);
            var firstTire = new Tire(tire1Age, tire1Pressure);

            double tire2Pressure = double.Parse(parameters[7]);
            int tire2Age = int.Parse(parameters[8]);
            var secondTire = new Tire(tire2Age, tire2Pressure);

            double tire3Pressure = double.Parse(parameters[9]);
            int tire3Age = int.Parse(parameters[10]);
            var thirdTire = new Tire(tire3Age, tire3Pressure);

            double tire4Pressure = double.Parse(parameters[11]);
            int tire4Age = int.Parse(parameters[12]);
            var fourthTire = new Tire(tire4Age, tire4Pressure);

            var car = new Car(model, engineSpeed, enginePower,
                cargoWeight, cargoType, firstTire, secondTire, thirdTire, fourthTire);

            return car;
        }
    }
}

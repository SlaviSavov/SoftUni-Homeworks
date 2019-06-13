using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Raw_Data
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var carsList = new CarsList();

            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine()
                    .Split()
                    .ToArray();
                var model = token[0];
                Engine engine = new Engine(int.Parse(token[1]), int.Parse(token[2]));
                Cargo cargo = new Cargo(token[4], int.Parse(token[3]));
                Tire[] tires = new Tire[]
                {
                     new Tire( double.Parse(token[5]),int.Parse(token[6])),
                     new Tire( double.Parse(token[7]),int.Parse(token[8])),
                     new Tire( double.Parse(token[9]),int.Parse(token[10])),
                     new Tire( double.Parse(token[11]),int.Parse(token[12]))
                };
                var car = new Car(model, engine, cargo, tires);
                carsList.Add(car);
            }

            var command = Console.ReadLine();

            if (command== "flamable")
            {
                carsList.Flamable();
            }

            else if (command=="fragile")
            {
                carsList.Fragile();
            }
        }
    }
}

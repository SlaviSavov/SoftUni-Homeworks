using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Raw_Data
{
    public class Car
    {
        public string Model { get; set; }
        public Engine ModelEngine { get; set; }
        public Cargo ModelCargo { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string model,Engine engine,Cargo cargo,Tire[] tires)
        {
            Model = model;
            ModelEngine = engine;
            ModelCargo = cargo;
            Tires = tires;
        }
    }
}

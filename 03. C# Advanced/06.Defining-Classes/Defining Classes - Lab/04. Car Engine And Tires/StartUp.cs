﻿using System;

namespace _04._Car_Engine_And_Tires
{
    class Program
    {
        static void Main(string[] args)
        {
            var tires = new Tire[4];
            {
                new Tire(1, 2.5);
                new Tire(1, 2.5);
                new Tire(1, 2.5);
                new Tire(1, 2.5);
            }

            var engine = new Engine(560, 6300);

            var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);




            Console.WriteLine(car.WhoAmI());
        }
    }
}

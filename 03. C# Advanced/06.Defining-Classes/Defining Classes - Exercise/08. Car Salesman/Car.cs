﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Car_Salesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        public override string ToString()
        {
            var result = $"{Model}:"
            + Environment.NewLine
            + Engine.ToString()
            + $"  Weight: {Weight}"
            + Environment.NewLine
            + $"  Color: {Color}"
            + Environment.NewLine;

            return result;
        }
    }
}

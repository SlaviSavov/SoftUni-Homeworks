﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Car_Salesman
{
    public class Engine
    {

        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power, string displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }
        public override string ToString()
        {
            var result = $"  {Model}:"
            + Environment.NewLine
            + $"    Power: {Power}"
            + Environment.NewLine
            + $"    Displacement: {Displacement}"
            + Environment.NewLine
            + $"    Efficiency: {Efficiency}"
            + Environment.NewLine;

            return result;
        }


    }
}

﻿using System.Text;

namespace P02_CarsSalesman
{
    public class Engine
    {
        private const string offset = "  ";

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
            Displacement = -1;
            Efficiency = "n/a";
        }

        public Engine(string model, int power, int displacement)
            : this(model, power)
        {
            Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            Efficiency= efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            : this(model, power)
        {
            Displacement= displacement;
            Efficiency= efficiency;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{offset}{Model}:");
            sb.AppendLine($"{offset}{offset}Power: {Power}");
            sb.AppendLine($"{offset}{offset}Displacement: {(this.Displacement == -1 ? "n/a" : this.Displacement.ToString())}");
            sb.Append($"{offset}{offset}Efficiency: {Efficiency}");

            return sb.ToString().TrimEnd();
        }
    }

}

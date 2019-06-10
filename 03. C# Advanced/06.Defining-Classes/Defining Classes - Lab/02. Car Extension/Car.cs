using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Car_Extension
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            bool canContinue = this.FuelQuantity - (distance * this.FuelConsumption) >= 0;

            if (canContinue)
                this.FuelQuantity -= distance * this.FuelConsumption;
            else
                Console.WriteLine("Not enough fuel to perform this trip!");
        }
        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.Append($"Fuel: {this.FuelQuantity:F2}L");
            return sb.ToString();
        }
    }
}

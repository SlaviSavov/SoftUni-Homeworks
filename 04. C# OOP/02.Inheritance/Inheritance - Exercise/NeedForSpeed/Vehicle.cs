﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public virtual double FuelConsumption => DefaultFuelConsumption;
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public Vehicle(int horsePower,double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        public virtual void Drive(double kilometers)
        {
            double fuelNeeded = this.FuelConsumption + kilometers;
            if (Fuel >= fuelNeeded)
            {
                Fuel -= fuelNeeded;
            }
        }
    }
}

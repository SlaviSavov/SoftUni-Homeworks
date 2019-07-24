using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Vehicles.Models.Entities
{
    public class Truck
    {
        private const double AC_ON_FUEL_CONSUMPTION = 1.6;


        public Truck(double fuelQuantity, double fuelConsumption)
        {
            FuelConsumptionPerKm = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumptionPerKm { get; private set; }

        public bool CanDrive(double distance)
        {
            if (FuelQuantity - (distance * (FuelConsumptionPerKm + AC_ON_FUEL_CONSUMPTION)) < 0)
            {
                return false;
            }
            return true;
        }

        public void Drive(double distance)
        {
            FuelQuantity -= (distance * (FuelConsumptionPerKm + AC_ON_FUEL_CONSUMPTION));
        }

        public void Refuel(double liters)
        {
            FuelQuantity += liters * 0.95;
        }

        public override string ToString()
        {
            return $"Truck: {FuelQuantity:F2}";
        }

    }
}

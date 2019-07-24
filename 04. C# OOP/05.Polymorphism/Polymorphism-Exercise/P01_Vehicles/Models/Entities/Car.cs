using P01_Vehicle.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Vehicles.Models.Entities
{
    public class Car : IVehicle
    {
        private const double AC_ON_FUEL_CONSUMPTION = 0.9;

        public Car(double fuelQuantity,double fuelConsumption)
        {
            FuelConsumptionPerKm = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumptionPerKm { get; private set; }


        public bool CanDrive(double distance)
        {
            if (FuelQuantity - (distance * (FuelConsumptionPerKm + AC_ON_FUEL_CONSUMPTION))<0)
            {
                return false;
            }
            return true;
        }

        public void Drive(double distance)
        {
            FuelQuantity -= (distance*(FuelConsumptionPerKm+AC_ON_FUEL_CONSUMPTION));
        }

        public void Refuel(double liters)
        {
            FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"Car: {FuelQuantity:F2}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Vehicle.Models.Contracts
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumptionPerKm { get; }
        void Drive(double distance);
        void Refuel(double liters);
    }
}

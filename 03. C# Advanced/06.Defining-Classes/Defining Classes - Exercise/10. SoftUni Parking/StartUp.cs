namespace SoftUniParking
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");

            var parking = new Parking(0);
            Console.WriteLine(parking.AddCar(car));
            Console.WriteLine(parking.RemoveCar("sa"));

        }
    }
}

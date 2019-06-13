using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Raw_Data
{
    public class CarsList
    {
        private List<Car> carsList;

        public CarsList()
        {
            carsList = new List<Car>();
        }

        public void Add(Car car)
        {
            carsList.Add(car);
        }
        public void Fragile()
        {
            foreach (var car in carsList)
            {
                bool isLowPressure = false;
                foreach (var tire in car.Tires)
                {
                    if (tire.TirePressure<1)
                    {
                        isLowPressure = true;
                    }
                }
                if (isLowPressure)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
        public void Flamable()
        {
            foreach (var car in carsList)
            {
                if (car.ModelEngine.Power >=250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}

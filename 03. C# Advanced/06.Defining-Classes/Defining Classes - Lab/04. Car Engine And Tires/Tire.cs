using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Car_Engine_And_Tires
{
    class Tire
    {
        public int Year { get; set; }
        public double Pressure { get; set; }
        public Tire(int year,double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}

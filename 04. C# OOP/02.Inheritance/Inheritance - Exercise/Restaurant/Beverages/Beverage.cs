using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverages
{
    public class Beverage : Product
    {
        public double Milliliters { get; set; }

        public Beverage(string name, decimal price,double millilitres)
            : base(name, price)
        {
            Milliliters = millilitres;
        }
    }
}

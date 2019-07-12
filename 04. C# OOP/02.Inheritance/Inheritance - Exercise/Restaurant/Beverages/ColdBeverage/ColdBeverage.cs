using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverages.ColdBeverage
{
    public class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double millilitres) 
            : base(name, price, millilitres)
        {
        }
    }
}

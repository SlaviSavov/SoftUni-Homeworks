using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverages.HotBeverage
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMillilitres = 50;
        private const decimal CoffeePrice=3.5m;
        public double Caffeine { get; set; }


        public Coffee(string name,double caffeine) 
            : base(name, CoffeePrice,CoffeeMillilitres)
        {
            Caffeine = caffeine;
        }
    }
}

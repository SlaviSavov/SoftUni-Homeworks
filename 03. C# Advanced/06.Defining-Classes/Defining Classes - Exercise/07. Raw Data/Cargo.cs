using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Raw_Data
{
    public class Cargo
    {
        public string CargoType { get; set; }
        public int CargoWeight { get; set; }

        public Cargo(string type,int weight)
        {
            CargoWeight = weight;
            CargoType = type;
        }
    }
}

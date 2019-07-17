using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Ferrari
{
    public class Ferrari : ICar
    {
        public string Model { get; private set; }

        public string DriverName { get; private set; }

        public Ferrari(string name)
        {
            DriverName = name;
            Model = "488-Spider";
        }

        public string Brake()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }
    }
}

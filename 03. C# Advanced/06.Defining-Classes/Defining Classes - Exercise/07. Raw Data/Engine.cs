﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Raw_Data
{
    public class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }

        public Engine(int speed,int power)
        {
            Speed = speed;
            Power = power;
        }
    }
}

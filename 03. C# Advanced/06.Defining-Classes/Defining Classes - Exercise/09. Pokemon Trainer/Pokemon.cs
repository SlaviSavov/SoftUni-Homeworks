using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Pokemon_Trainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public string Element { get; set; }
        public int Health { get; set; }

        public Pokemon(string name,string element,int health)
        {
            this.name = name;
            Element = element;
            Health = health;
        }
        public void ReduceHealth()
        {
            this.health -= 10;
        }
    }
}

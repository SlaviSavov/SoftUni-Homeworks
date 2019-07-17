using P07_FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07_FoodShortage.Models
{
    public class Rebel:IPerson,IBuyer
    {
        public int Food { get; set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Group { get; private set; }

        public Rebel(string name, int age, string group)
        {
            Food = 0;
            Name = name;
            Age = age;
            Group = group;
        }
        public void BuyFood()
        {
            this.Food += 5;
        }

    }
}

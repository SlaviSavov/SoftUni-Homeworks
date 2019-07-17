using P07_FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07_FoodShortage.Models
{
    public class Citizen : IPerson, IBuyer
    {
        public int Food { get; set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string BirthDate { get; private set; }

        public Citizen(string name,int age,string id,string birthDate)
        {
            Food = 0;
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
        }
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}

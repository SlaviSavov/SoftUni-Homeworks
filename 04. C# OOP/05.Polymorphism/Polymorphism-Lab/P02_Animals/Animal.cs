﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public string Name { get;private set; }
        public string FavouriteFood { get;private set; }

        public Animal(string name,string food)
        {
            Name = name;
            FavouriteFood = food;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavouriteFood }";
        }
    }
}

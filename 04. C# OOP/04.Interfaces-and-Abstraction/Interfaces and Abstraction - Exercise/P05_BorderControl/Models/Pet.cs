using System;
using System.Collections.Generic;
using System.Text;

namespace P05_BorderControl.Models
{
    public class Pet
    {
        public string Name { get;private set; }
        public string Birthdate { get; set; }

        public Pet(string name,string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
}

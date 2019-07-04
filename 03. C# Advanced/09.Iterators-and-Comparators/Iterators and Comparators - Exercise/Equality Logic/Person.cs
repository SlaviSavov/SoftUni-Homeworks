using System;
using System.Collections.Generic;
using System.Text;

namespace Equality_Logic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Age.GetHashCode() + (257 * 53);
        }
        public override bool Equals(object obj)
        {
            return Name==((Person)obj).Name&&Age==((Person)obj).Age;
        }

        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.Name);
            if (result == 0)
            {
                return Age.CompareTo(other.Age);
            }
            return result;
        }
    }
}

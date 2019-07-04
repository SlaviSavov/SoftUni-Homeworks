using System;
using System.Collections.Generic;
using System.Linq;

namespace Comparing_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            string input;

            while ((input=Console.ReadLine())!="END")
            {
                var tokens = input
                    .Split()
                    .ToArray();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                var person = new Person(name, age, town);
                people.Add(person);
            }
            int n = int.Parse(Console.ReadLine());


            int countOfMatches = 1;
            int countOfNotEqualPeople = 0;

            Person targetPerson = people[n - 1];

            foreach (var item in people)
            {
                if (item==targetPerson)
                {
                    continue;
                }
                if (item.CompareTo(targetPerson)==0)
                {
                    countOfMatches++;
                }
                else 
                {
                    countOfNotEqualPeople++;
                }
            }
            if (countOfMatches==1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {countOfNotEqualPeople} {people.Count}");
            }

        }
    }
}

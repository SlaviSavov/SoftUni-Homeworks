using System;
using System.Collections.Generic;
using System.Linq;

namespace Equality_Logic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<Person> hashSet = new HashSet<Person>();
            SortedSet<Person> sortedSet = new SortedSet<Person>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                var person = new Person(name, age);

                hashSet.Add(person);
                sortedSet.Add(person);
            }


            Console.WriteLine(hashSet.Count);
            Console.WriteLine(sortedSet.Count);
        }
    }
}

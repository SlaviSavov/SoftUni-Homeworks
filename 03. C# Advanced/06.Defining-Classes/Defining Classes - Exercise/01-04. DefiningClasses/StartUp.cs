using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var familyMember = new Family();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();
                var name = input[0];
                var age = int.Parse(input[1]);

                Person person = new Person(name, age);

                familyMember.AddMember(person);
            }

            foreach (var item in familyMember.FilteredFamily())
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}

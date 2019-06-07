﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            var people = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < peopleCount; i++)
            {
                var person = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add(new KeyValuePair<string, int>(person[0], int.Parse(person[1])));
            }
            var filter = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var printPattern = Console.ReadLine()
                .Split(' ');

            people
                .Where(p => filter == "younger" ? p.Value <= age : p.Value >= age)
                .ToList()
                .ForEach(p => Printer(p, printPattern));

        }
        static void Printer(KeyValuePair<string, int> person, string[] printerPattern)
        {
            if (printerPattern.Length == 2)
            {
                Console.WriteLine($"{person.Key} - {person.Value}");
            }
            else
            {
                Console.WriteLine(printerPattern[0] == "name" ?
                    $"{person.Key}" :
                    $"{person.Value}");
            }
        }
    }
}

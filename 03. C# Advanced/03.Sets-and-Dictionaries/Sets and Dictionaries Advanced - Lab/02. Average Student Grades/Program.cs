using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string student = input[0];
                double grade =double.Parse( input[1]);

                if (!studentsGrades.ContainsKey(student))
                {
                    studentsGrades.Add(student, new List<double>());
                }
                studentsGrades[student].Add(grade);
            }
            foreach (var item in studentsGrades)
            {
                Console.WriteLine();

                Console.Write($"{item.Key} -> ");

                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {item.Value.Average():f2})");
            }
        }
    }
}

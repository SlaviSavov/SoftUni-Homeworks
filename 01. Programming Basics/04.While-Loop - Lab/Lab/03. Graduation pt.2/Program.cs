using System;

namespace _03._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = 0;
            double classes = 1;
            double badGrades = 0;
            while (classes <= 12)
            {
                double num = double.Parse(Console.ReadLine());
                if (num >= 4)
                {
                    grade = num + grade;
                    classes++;
                }
                else
                {
                    badGrades++;
                    if (badGrades > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {classes} grade");
                        return;
                    }
                }
            }
            double avg = grade / 12;
            Console.WriteLine($"{name} graduated. Average grade: {avg:F2}");

        }
    }
}

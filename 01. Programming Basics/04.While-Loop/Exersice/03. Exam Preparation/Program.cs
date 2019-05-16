using System;

namespace _03._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poor = int.Parse(Console.ReadLine());
            double avgEv = 0;
            double tryy = 0;
            string lastTask = "";
            double poorEv = 0;

            while (true)
            {
                string nameOfTask = Console.ReadLine();
                if (nameOfTask == "Enough")
                {
                    Console.WriteLine($"Average score: {avgEv / tryy:F2}");
                    Console.WriteLine($"Number of problems: {tryy}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    return;
                }
                int ev = int.Parse(Console.ReadLine());
                avgEv += ev;
                tryy++;
                if (ev <= 4) poorEv++;

                if (poor == poorEv)
                {
                    Console.WriteLine($"You need a break, {poorEv} poor grades.");
                    return;
                }
                lastTask = nameOfTask;
            }
        }
    }
}

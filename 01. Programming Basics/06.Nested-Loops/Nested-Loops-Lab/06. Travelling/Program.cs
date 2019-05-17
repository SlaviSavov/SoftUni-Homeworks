using System;

namespace _06._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                double sum = 1;
                string destination = Console.ReadLine();
                if (destination == "End") return;
                double targetSum = double.Parse(Console.ReadLine());

                while (sum <= targetSum)
                {
                    double input = double.Parse(Console.ReadLine());
                    sum += input;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}

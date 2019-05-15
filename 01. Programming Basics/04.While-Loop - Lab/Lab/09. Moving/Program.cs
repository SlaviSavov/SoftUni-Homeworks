using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double room = w * l * h;
            double box = 0;

            while (room >= box)
            {
                string prom = Console.ReadLine();
                if (prom == "Done")
                {
                    Console.WriteLine($"{room - box} Cubic meters left.");
                    return;
                }
                int boxs = int.Parse(prom);
                box += boxs;
            }
            Console.WriteLine($"No more free space! You need {box - room} Cubic meters more.");
        }
    }
}

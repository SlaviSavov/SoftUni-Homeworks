using System;

namespace P03_Ferrari
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();

            Ferrari ferrari = new Ferrari(driverName);

            Console.WriteLine($"{ferrari.Model}/{ferrari.Brake()}/{ferrari.Gas()}/{ferrari.DriverName}");
        }
    }
}

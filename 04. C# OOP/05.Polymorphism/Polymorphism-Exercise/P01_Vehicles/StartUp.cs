using P01_Vehicles.Core;
using System;

namespace P01_Vehicles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();

            engine.Run();
        }
    }
}

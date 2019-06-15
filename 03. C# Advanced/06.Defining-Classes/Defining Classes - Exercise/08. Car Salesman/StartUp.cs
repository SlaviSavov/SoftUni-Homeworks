using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Car_Salesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engineList = new List<Engine>();
            List<Car> carList = new List<Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();
                string engineName = input[0];
                int power = int.Parse(input[1]);
                string displacement = input[2];
                string efficiency = "n/a";
                if (input.Length == 4)
                {
                    efficiency = input[3];
                }
                var engine = new Engine(engineName, power, displacement, efficiency);
                engineList.Add(engine);
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();
                string model = input[0];
                string engine = input[1];
                string weight = "n/a";
                string color = "n/a";
                if (input.Length == 4)
                {
                    weight = input[2];
                   color = input[3];
                }
                else if (input.Length==3)
                {

                    weight = input[2];
                }
                var car = new Car(model, engine, weight, color);
                carList.Add(car);
            }



            foreach (var item in carList)
            {
                Engine eng = engineList.Where(e => e.Model == item.Engine);
                Console.WriteLine();
            }
        }
    }
}

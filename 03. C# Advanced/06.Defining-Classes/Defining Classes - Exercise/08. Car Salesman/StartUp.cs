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
                Engine engine = engineList.FirstOrDefault(e => e.Model == input[1]);
                string weight = "n/a";
                string color = "n/a";
                if (input.Length > 2)
                {
                    int tempWeight=0;
                    var isDigit = int.TryParse(input[2], out tempWeight);


                    if (!isDigit)
                    {
                        color = input[2];
                    }

                    if (input.Length > 3)
                    {
                        if (isDigit)
                        {
                            tempWeight = int.Parse(input[2]);
                            color = input[3];
                        }
                    }
                    if (tempWeight == 0)
                    {
                        weight = "n/a";
                    }
                    else
                    {
                        weight = $"{weight}";
                    }
                }
                var car = new Car(model, engine, weight, color);
                carList.Add(car);
            }


            foreach (var item in carList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

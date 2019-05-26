using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new HashSet<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine())!="END")
            {
                var direction = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)[0];
                var carNumber= input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)[1];

                switch (direction?.ToLower())
                {
                    case "in":
                        parking.Add(carNumber);
                        break;
                    case "out":
                        parking.Remove(carNumber);
                        break;
                    default:
                        break;
                }
            }
            if (parking.Count>0)
            {
                foreach (var item in parking)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}

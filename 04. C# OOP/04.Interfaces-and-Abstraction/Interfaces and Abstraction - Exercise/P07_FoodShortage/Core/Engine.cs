using P07_FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P07_FoodShortage.Core
{
    public class Engine
    {
        private List<Rebel> rebels;
        private List<Citizen> citizens;
        public Engine()
        {
            this.rebels = new List<Rebel>();
            this.citizens = new List<Citizen>();
        }
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            AddDate(n);

            Shopping();

            PrintSumOfAllFoods();
        }

        private void PrintSumOfAllFoods()
        {
            int result = rebels.Sum(r => r.Food) + citizens.Sum(c => c.Food);

            Console.WriteLine(result);
        }

        private void Shopping()
        {
            var command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                var nameOfBuyer = command;

                foreach (var rebel in rebels)
                {
                    if (rebel.Name == nameOfBuyer)
                    {
                        rebel.BuyFood();
                    }
                }
                foreach (var citizen in citizens)
                {
                    if (citizen.Name == nameOfBuyer)
                    {
                        citizen.BuyFood();
                    }
                }
            }
        }

        private void AddDate(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);


                if (input.Length == 3)
                {
                    string group = input[2];

                    var rebel = new Rebel(name, age, group);

                    rebels.Add(rebel);
                }
                else if (input.Length == 4)
                {
                    string id = input[2];
                    string birthDate = input[3];

                    var citizen = new Citizen(name, age, id, birthDate);

                    citizens.Add(citizen);
                }
            }
        }
    }
}

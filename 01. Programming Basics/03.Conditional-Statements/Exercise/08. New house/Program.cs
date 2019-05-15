using System;

namespace _08._New_house
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int amountOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if (flowerType == "Roses")
            {
                price = amountOfFlowers * 5;

                if (amountOfFlowers > 80)
                {
                    price *= 0.9;
                }
            }
            else if (flowerType == "Dahlias")
            {
                price = amountOfFlowers * 3.8;

                if (amountOfFlowers > 90)
                {
                    price *= 0.85;
                }
            }
            else if (flowerType == "Tulips")
            {
                price = amountOfFlowers * 2.8;

                if (amountOfFlowers > 80)
                {
                    price *= 0.85;
                }
            }
            else if (flowerType == "Narcissus")
            {
                price = amountOfFlowers * 3;

                if (amountOfFlowers < 120)
                {
                    price += (price * 0.15);
                }
            }
            else if (flowerType == "Gladiolus")
            {
                price = amountOfFlowers * 2.50;

                if (amountOfFlowers < 80)
                {
                    price += (price * 0.20);
                }
            }

            double difference = Math.Abs(budget - price);

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {amountOfFlowers} {flowerType} and {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
            }

        }
    }
}

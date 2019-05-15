using System;

namespace _07._Summer_outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string daytime = Console.ReadLine();

            if (degree >= 10 && degree <= 18)
            {
                if (daytime == "Morning")
                {
                    string outfit = "Sweatshirt";
                    string shoes = "Sneakers";
                    Console.WriteLine("It's {2} degrees, get your {0} and {1}.", outfit, shoes, degree);
                }
                else if (daytime == "Afternoon")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine("It's {2} degrees, get your {0} and {1}.", outfit, shoes, degree);
                }
                else if (daytime == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine("It's {2} degrees, get your {0} and {1}.", outfit, shoes, degree);
                }
            }
            else if (degree > 18 && degree <= 24)
            {
                if (daytime == "Morning")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine("It's {2} degrees, get your {0} and {1}.", outfit, shoes, degree);
                }
                else if (daytime == "Afternoon")
                {
                    string outfit = "T-Shirt";
                    string shoes = "Sandals";
                    Console.WriteLine("It's {2} degrees, get your {0} and {1}.", outfit, shoes, degree);
                }
                else if (daytime == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine("It's {2} degrees, get your {0} and {1}.", outfit, shoes, degree);
                }
            }
            else if (degree >= 25)
            {
                if (daytime == "Morning")
                {
                    string outfit = "T-Shirt";
                    string shoes = "Sandals";
                    Console.WriteLine("It's {2} degrees, get your {0} and {1}.", outfit, shoes, degree);
                }
                else if (daytime == "Afternoon")
                {
                    string outfit = "Swim Suit";
                    string shoes = "Barefoot";
                    Console.WriteLine("It's {2} degrees, get your {0} and {1}.", outfit, shoes, degree);
                }
                else if (daytime == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine("It's {2} degrees, get your {0} and {1}.", outfit, shoes, degree);
                }
            }
        }
    }
}

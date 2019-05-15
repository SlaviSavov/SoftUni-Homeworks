using System;

namespace _12._Hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {

            string Month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double LastPriceStudio = 0;
            double LastPriceApartment = 0;
            if (nights <= 0)
            {
                LastPriceStudio = 0;
                LastPriceApartment = 0;
            }
            else if (nights >= 1 && nights <= 7 && (Month == "May" || Month == "October"))
            {
                LastPriceStudio = 50;
                LastPriceApartment = 65;
            }
            else if ((nights >= 1) && (nights <= 7) && (Month == "June" || Month == "September"))
            {
                LastPriceStudio = 75.2;
                LastPriceApartment = 68.7;
            }
            else if ((nights >= 1) && (nights <= 7) && (Month == "July" || Month == "August"))
            {
                LastPriceStudio = 76;
                LastPriceApartment = 77;
            }
            else if (nights > 7 && nights <= 14 && (Month == "May" || Month == "October"))
            {
                LastPriceStudio = 50 - 0.05 * 50;
                LastPriceApartment = 65;
            }
            else if ((nights > 7) && (nights <= 14) && (Month == "June" || Month == "September"))
            {
                LastPriceStudio = 75.2;
                LastPriceApartment = 68.7;
            }
            else if ((nights > 7) && (nights <= 14) && (Month == "July" || Month == "August"))
            {
                LastPriceStudio = 76;
                LastPriceApartment = 77;
            }
            else if ((nights > 14) && (Month == "May" || Month == "October"))
            {
                LastPriceStudio = 50 - 0.3 * 50;
                LastPriceApartment = 65 - 0.1 * 65;
            }
            else if ((nights > 14) && (Month == "June" || Month == "September"))
            {
                LastPriceStudio = 75.2 - 0.2 * 75.2;
                LastPriceApartment = 68.7 - 0.1 * 68.7;
            }
            else if ((nights > 14) && (Month == "July" || Month == "August"))
            {
                LastPriceStudio = 76;
                LastPriceApartment = 77 - 0.1 * 77;
            }
            Console.WriteLine("Apartment: {0:f2} lv.", nights * LastPriceApartment);
            Console.WriteLine("Studio: {0:f2} lv.", nights * LastPriceStudio);
        }
    }
}

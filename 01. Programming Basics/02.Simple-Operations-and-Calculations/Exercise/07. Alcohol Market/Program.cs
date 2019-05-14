using System;

namespace _07._Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWiskey = double.Parse(Console.ReadLine());

            double priceRakiq = priceWiskey / 2;
            double priceWine = priceRakiq - (0.4 * priceRakiq);
            double priceBeer = priceRakiq - (0.8 * priceRakiq);

            double coBeer = double.Parse(Console.ReadLine());
            double coWine = double.Parse(Console.ReadLine());
            double coRakiq = double.Parse(Console.ReadLine());
            double coWiskey = double.Parse(Console.ReadLine());
            double beer = coBeer * priceBeer;
            double wine = coWine * priceWine;
            double rakiq = coRakiq * priceRakiq;
            double wiskey = coWiskey * priceWiskey;


            double price = beer + wine + rakiq + wiskey;
            Console.WriteLine("{0:F2}", price);
        }
    }
}

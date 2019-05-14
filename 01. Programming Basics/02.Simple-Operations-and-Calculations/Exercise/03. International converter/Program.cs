using System;

namespace _03._International_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();

            double result = 0;

            if (inputCurrency=="BGN")
            {
                if (outputCurrency=="USD")
                {
                    result = money / 1.79549;
                }
                else if (outputCurrency=="EUR")
                {
                    result = money / 1.95583;
                }
                else if (outputCurrency=="GBP")
                {
                    result = money / 2.53405;
                }
            }
            else if (inputCurrency=="USD")
            {
                money *=1.79549;
                if (outputCurrency=="BGN")
                {
                    result = money;
                }
                else if (outputCurrency == "EUR")
                {
                    result = money / 1.95583;
                }
                else if (outputCurrency == "GBP")
                {
                    result = money / 2.53405;
                }

            }
            else if (inputCurrency=="EUR")
            {
                money *= 1.95583;
                if (outputCurrency=="BGN")
                {
                    result = money;
                }
                else if (outputCurrency == "GBP")
                {
                    result = money / 2.53405;
                }
                else if (outputCurrency == "USD")
                {
                    result = money / 1.79549;
                }
            }
            else if (inputCurrency=="GBP")
            {
                money *= 2.53405;
                if (inputCurrency=="BGN")
                {
                    result = money;
                }
                else if (outputCurrency == "USD")
                {
                    result = money / 1.79549;
                }
                else if (outputCurrency == "EUR")
                {
                    result = money / 1.95583;
                }

            }
            Console.WriteLine($"{result:f2} {outputCurrency}");
        }
    }
}

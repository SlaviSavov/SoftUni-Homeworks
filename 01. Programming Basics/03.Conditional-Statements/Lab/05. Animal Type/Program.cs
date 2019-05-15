using System;

namespace _05._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            switch (input)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}

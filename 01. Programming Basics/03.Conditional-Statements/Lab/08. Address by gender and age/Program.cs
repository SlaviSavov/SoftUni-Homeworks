using System;

namespace _08._Address_by_gender_and_age
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var gender = char.Parse(Console.ReadLine());

            if (age < 16)
            {
                if (gender == 'm')
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (gender == 'm')
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }

            }
        }
    }
}

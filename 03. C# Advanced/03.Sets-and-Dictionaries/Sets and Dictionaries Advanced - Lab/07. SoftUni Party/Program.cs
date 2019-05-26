using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var guestsList = new SortedSet<string>();

            var input = string.Empty;

            while ((input = Console.ReadLine())?.ToLower()!="party")
            {
                guestsList.Add(input);
            }
            while ((input = Console.ReadLine())?.ToLower() != "end")
            {
                guestsList.Remove(input);
            }
            Console.WriteLine(guestsList.Count);
            foreach (var guest in guestsList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}

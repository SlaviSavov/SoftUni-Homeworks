using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var usernames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                usernames.Add(Console.ReadLine());
            }
            foreach (var user in usernames)
            {
                Console.WriteLine(user);
            }
        }
    }
}

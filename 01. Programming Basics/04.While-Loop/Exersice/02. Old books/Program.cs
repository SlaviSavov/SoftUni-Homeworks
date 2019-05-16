using System;

namespace _02._Old_books
{
    class Program
    {
        static void Main(string[] args)
        {
            string target = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int time = 0;
            string name = "";

            while (num > time && name != target)
            {
                string bookName = Console.ReadLine();
                name = bookName;
                time++;
            }
            if (target == name && num >= time)
            {
                Console.WriteLine($"You checked {time - 1} books and found it.");
            }
            else if (num <= time)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {time} books.");
            }
        }
    }
}

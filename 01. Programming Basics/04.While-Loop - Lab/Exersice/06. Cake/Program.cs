using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int cake = w * l;
            int piece = 0;

            while (true)
            {
                string input1 = Console.ReadLine();

                if (input1 == "STOP" && cake >= piece)
                {
                    Console.WriteLine($"{cake - piece} pieces are left.");
                    return;
                }
                else if (cake < piece)
                {
                    Console.WriteLine($"No more cake left! You need {piece - cake} pieces more.");
                    return;
                }
                int input = int.Parse(input1);
                piece += input;
            }
    }
}

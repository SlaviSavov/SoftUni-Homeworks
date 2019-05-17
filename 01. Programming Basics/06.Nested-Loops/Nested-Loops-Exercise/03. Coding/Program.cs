using System;

namespace _03._Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            while (input!=0)
            {
                int num = input % 10;
                if (num==0)
                {
                    Console.WriteLine("ZERO");
                }
                else
                {
                    for (int i = 0; i < num; i++)
                    {
                        Console.Write((char)(33 + num));
                    }
                    Console.WriteLine();
                }
                input /= 10;
            }
        }
    }
}

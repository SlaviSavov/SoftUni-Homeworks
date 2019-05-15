using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1 = int.Parse(Console.ReadLine());
            int r2 = int.Parse(Console.ReadLine());
            int r3 = int.Parse(Console.ReadLine());
            int result = r1 + r2 + r3;
            if (result <= 59)
            {
                if (result < 10)
                {
                    Console.WriteLine("0:0" + result);
                }
                else
                {
                    Console.WriteLine("0:" + result);
                }
            }
            else if (result <= 119)
            {
                int result2 = result - 60;
                if (result2 <= 59)
                {
                    if (result2 < 10)
                    {
                        Console.WriteLine("1:0" + result2);
                    }
                    else
                    {
                        Console.WriteLine("1:" + result2);
                    }
                }
            }
            else if (result <= 179)
            {
                int result3 = result - 120;
                if (result3 <= 59)
                {
                    if (result3 < 10)
                    {
                        Console.WriteLine("2:0" + result3);
                    }
                    else
                    {
                        Console.WriteLine("2:" + result3);
                    }
                }

            }
        }
    }
}

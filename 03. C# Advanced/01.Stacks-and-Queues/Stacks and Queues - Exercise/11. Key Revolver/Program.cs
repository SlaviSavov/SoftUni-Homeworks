namespace _11._Key_Revolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            var bullets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var locks = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int payment =int.Parse( Console.ReadLine());

            Stack<int> stackOfbullets = new Stack<int>(bullets);
            Queue<int> queueOfLocks = new Queue<int>(locks);

            int shot = 0;

            while (stackOfbullets.Count>0&&queueOfLocks.Count>0)
            {
                if (queueOfLocks.Peek()>=stackOfbullets.Pop())
                {
                    queueOfLocks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                shot++;
                if (shot % sizeOfGunBarrel == 0 && stackOfbullets.Count() != 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            if (stackOfbullets.Count==0&& queueOfLocks.Count != 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueOfLocks.Count}");
            }
            else
            {
                int moneyEarned = payment-(shot*bulletPrice) ;
                Console.WriteLine($"{stackOfbullets.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}

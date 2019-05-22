namespace _06._Bomb_the_Basement
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var basemant = new int[dimensions[0], dimensions[1]];

            int[] cordinates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int targetRow = cordinates[0];
            int targetCol = cordinates[1];
            int radius = cordinates[2];

            for (int row = 0; row < basemant.GetLength(0); row++)
            {
                for (int col = 0; col < basemant.GetLength(1); col++)
                {
                    bool isInRadius = Math.Pow(row - targetRow, 2) + Math.Pow(col - targetCol, 2) <= Math.Pow(radius, 2);
                    if (isInRadius)
                    {
                        basemant[row, col] = 1;
                    }
                }
            }

            int[] numOfOneInCol = new int[basemant.GetLength(1)];

            for (int col = 0; col < basemant.GetLength(1); col++)
            {
                for (int row = 0; row < basemant.GetLength(0); row++)
                {
                    if (basemant[row, col] == 1)
                    {
                        numOfOneInCol[col]++;
                    }
                }
            }

            var result = new int[dimensions[0], dimensions[1]];

            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    if (numOfOneInCol[col] > 0)
                    {
                        result[row, col] = 1;
                        numOfOneInCol[col]--;
                    }
                    Console.Write(result[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
namespace _03._Maximal_Sum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int maxSum = int.MinValue;
            int row = 0;
            int col = 0;

            for (int i = 0; i < matrix.GetLength(0)-2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-2; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (maxSum<sum)
                    {
                        maxSum = sum;
                        row = i;
                        col = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[row,col]} {matrix[row, col+1]} {matrix[row, col+2]}\n" +
                $"{matrix[row+1, col]} {matrix[row + 1, col+1]} {matrix[row + 1, col+2]}\n" +
                $"{matrix[row + 2, col]} {matrix[row + 2, col+1]} {matrix[row + 2, col+2]}");
        }
    }
}

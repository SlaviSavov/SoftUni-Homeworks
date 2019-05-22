namespace _01._Diagonal_Difference
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size,size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            for (int i = 0; i < size; i++)
            {
                sumPrimaryDiagonal += matrix[i, i];
                sumSecondaryDiagonal += matrix[i, Math.Abs(i - (size-1))];
            }
            Console.WriteLine(Math.Abs(sumPrimaryDiagonal-sumSecondaryDiagonal));

        }
    }
}

using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var matrix = new string[size[0], size[1]];

            for (int i = 0; i < size[0]; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            string command;

            while ((command=Console.ReadLine())?.ToLower()!="end")
            {
                string[] info = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (info[0]=="swap"
                    &&info.Length==5
                    &&int.Parse(info[1])<size[0]
                    && int.Parse(info[2]) < size[1]
                    && int.Parse(info[3]) < size[0]
                    && int.Parse(info[4]) < size[1])
                {
                    string firstElement = matrix[int.Parse(info[1]), int.Parse(info[2])];
                    string secondElement = matrix[int.Parse(info[3]), int.Parse(info[4])];
                    matrix[int.Parse(info[1]), int.Parse(info[2])] = secondElement;
                    matrix[int.Parse(info[3]), int.Parse(info[4])] = firstElement;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

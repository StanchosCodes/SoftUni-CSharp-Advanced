using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            (int rows, int cols) = (dimensions[0], dimensions[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine()
                        .Split(" ")
                        .Select(int.Parse)
                        .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            long[] colsSums = new long[cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    colsSums[col] += matrix[row, col];
                }
            }

            Console.WriteLine(string.Join("\n", colsSums));
        }
    }
}

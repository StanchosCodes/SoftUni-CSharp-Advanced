using System;
using System.Linq;

namespace PimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            (int rows, int cols) = (dimensions, dimensions);

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

            long diagonalSum = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col == row)
                    {
                        diagonalSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(diagonalSum);
        }
    }
}

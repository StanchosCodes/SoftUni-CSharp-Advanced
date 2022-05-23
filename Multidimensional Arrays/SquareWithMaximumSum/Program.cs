using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the size of the matrix
            int[] dimensions = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            (int rowsCount, int colsCount) = (dimensions[0], dimensions[1]); // Short of int rows = dimensions[0]; int cols = dimensions[1];

            // Initialise the matrix
            int[,] matrix = new int[rowsCount, colsCount];

            // Fill the matrix by reading int[] from the console
            for (int row = 0; row < rowsCount; row++)
            {
                int[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            // Calculating the sum of the squares of the matrix one by one and taking only the biggest
            long biggestSum = long.MinValue;
            string bestSquare = string.Empty;

            for (int row = 0; row < rowsCount - 1; row++)
            {
                for (int col = 0; col < colsCount - 1; col++)
                {
                    long currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currSum > biggestSum)
                    {
                        biggestSum = currSum;
                        bestSquare = matrix[row, col] + " " + matrix[row, col + 1] + "\n" + matrix[row + 1, col] + " " + matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine(bestSquare);
            Console.WriteLine(biggestSum);
        }
    }
}

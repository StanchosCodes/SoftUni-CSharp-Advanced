using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }

            long maxSum = long.MinValue;
            string biggestSumMatrix = string.Empty;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    long currSum = matrix[row, col] +
                                   matrix[row, col + 1] +
                                   matrix[row, col + 2] +
                                   matrix[row + 1, col] +
                                   matrix[row + 1, col + 1] +
                                   matrix[row + 1, col + 2] +
                                   matrix[row + 2, col] +
                                   matrix[row + 2, col + 1] +
                                   matrix[row + 2, col + 2];

                    if (maxSum < currSum)
                    {
                        maxSum = currSum;
                        biggestSumMatrix = matrix[row, col] + " " +
                                           matrix[row, col + 1] + " " +
                                           matrix[row, col + 2] + " " + "\n" +
                                           matrix[row + 1, col] + " " +
                                           matrix[row + 1, col + 1] + " " +
                                           matrix[row + 1, col + 2] + " " + "\n" +
                                           matrix[row + 2, col] + " " +
                                           matrix[row + 2, col + 1] + " " +
                                           matrix[row + 2, col + 2]; 
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(biggestSumMatrix);
        }
    }
}

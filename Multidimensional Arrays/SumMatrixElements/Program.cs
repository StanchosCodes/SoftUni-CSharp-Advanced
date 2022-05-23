using System;
using System.Linq;

namespace SumMatrixElements
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

            //  Print the matrix
            //for (int row = 0; row < rowsCount; row++)
            //{
            //    for (int col = 0; col < colsCount; col++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // Calculate the matrix sum                             // The 0th is always the row and the 1st is always the col
            long sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++) // A way to take the length of rows is by asking for the 0th dimension
            {
                for (int col = 0; col < matrix.GetLength(1); col++) // Same as the rows is for cols to ask for the 1st dimension
                {
                    sum += matrix[row, col];
                }
            }

            // Desired output
            Console.WriteLine(rowsCount);
            Console.WriteLine(colsCount);
            Console.WriteLine(sum);
        }
    }
}

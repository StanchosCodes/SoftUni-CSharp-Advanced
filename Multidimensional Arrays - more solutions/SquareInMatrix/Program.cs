using System;
using System.Linq;

namespace SquareInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] symbols = Console.ReadLine().Split(' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }

            int matrixCount = 0;

            for (int row = 0; row < rows - 1; row++) // защото искаме да обходим матрицата да предпоследния ред за да не излезем от границите и
            {
                for (int col = 0; col < cols - 1; col++) // - 1 е пак за да не излезем от границите на матрицата
                {
                    if (matrix[row, col] == matrix[row, col + 1] && 
                        matrix[row, col] == matrix[row + 1, col] && 
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        matrixCount++;
                    }
                }
            }

            Console.WriteLine(matrixCount);
        }
    }
}

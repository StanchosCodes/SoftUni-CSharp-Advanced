using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int nRows = int.Parse(Console.ReadLine());

            long[][] triangle = new long[nRows][];

            for (int row = 0; row < triangle.Length; row++)
            {
                triangle[row] = new long[row + 1];
                triangle[row][0] = 1;

                for (int col = 1; col < row; col++)
                {
                    triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
                }

                triangle[row][row] = 1;
            }

            for (int row = 0; row < triangle.Length; row++)
            {
                Console.WriteLine(string.Join(" ", triangle[row]));
            }
        }
    }
}

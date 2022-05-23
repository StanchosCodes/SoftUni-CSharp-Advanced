using System;
using System.Linq;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            (int rows, int cols) = (dimensions, dimensions);

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string elementsString = Console.ReadLine();
                char[] elements = new char[elementsString.Length];

                for (int i = 0; i < elementsString.Length; i++)
                {
                    elements[i] = elementsString[i];
                }

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            char symbolToFind = char.Parse(Console.ReadLine());
            int[] indexOfTheElement = new int[2] { -1, -1};
            bool isSymbolFound = false;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    char element = matrix[row, col];
                    if (element == symbolToFind)
                    {
                        indexOfTheElement[0] = row;
                        indexOfTheElement[1] = col;
                        isSymbolFound = true;
                    }
                }
                if (isSymbolFound)
                {
                    break;
                }
            }

            if (!indexOfTheElement.Contains(-1))
            {
                Console.WriteLine("(" + string.Join(", ", indexOfTheElement) + ")");
            }
            else
            {
                Console.WriteLine($"{symbolToFind} does not occur in the matrix");
            }
        }
    }
}

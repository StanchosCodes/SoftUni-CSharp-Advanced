using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] bombField = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    bombField[row, col] = elements[col];
                }
            }

            string[] coordinates = Console.ReadLine().Split(" ");

            for (int row = 0; row < coordinates.Length; row++)
            {
                int currRowIndex = int.Parse(coordinates[row].Split(',')[0]);
                int currColIndex = int.Parse(coordinates[row].Split(',')[1]);

                int currBombValue = bombField[currRowIndex, currColIndex];
                if (currBombValue <= 0)
                {
                    continue;
                }
                bombField[currRowIndex, currColIndex] = 0;

                if (IsIndexValid(bombField, currRowIndex - 1, currColIndex))
                {
                    if (bombField[currRowIndex - 1, currColIndex] > 0)
                    {
                        bombField[currRowIndex - 1, currColIndex] -= currBombValue;
                    }
                }
                if (IsIndexValid(bombField, currRowIndex - 1, currColIndex - 1))
                {
                    if (bombField[currRowIndex - 1, currColIndex - 1] > 0)
                    {
                        bombField[currRowIndex - 1, currColIndex - 1] -= currBombValue;
                    }
                }
                if (IsIndexValid(bombField, currRowIndex - 1, currColIndex + 1))
                {
                    if (bombField[currRowIndex - 1, currColIndex + 1] > 0)
                    {
                        bombField[currRowIndex - 1, currColIndex + 1] -= currBombValue;
                    }
                }
                if (IsIndexValid(bombField, currRowIndex, currColIndex - 1))
                {
                    if (bombField[currRowIndex, currColIndex - 1] > 0)
                    {
                        bombField[currRowIndex, currColIndex - 1] -= currBombValue;
                    }
                }
                if (IsIndexValid(bombField, currRowIndex, currColIndex + 1))
                {
                    if (bombField[currRowIndex, currColIndex + 1] > 0)
                    {
                        bombField[currRowIndex, currColIndex + 1] -= currBombValue;
                    }
                }
                if (IsIndexValid(bombField, currRowIndex + 1, currColIndex))
                {
                    if (bombField[currRowIndex + 1, currColIndex] > 0)
                    {
                        bombField[currRowIndex + 1, currColIndex] -= currBombValue;
                    }
                }
                if (IsIndexValid(bombField, currRowIndex + 1, currColIndex - 1))
                {
                    if (bombField[currRowIndex + 1, currColIndex - 1] > 0)
                    {
                        bombField[currRowIndex + 1, currColIndex - 1] -= currBombValue;
                    }
                }
                if (IsIndexValid(bombField, currRowIndex + 1, currColIndex + 1))
                {
                    if (bombField[currRowIndex + 1, currColIndex + 1] > 0)
                    {
                        bombField[currRowIndex + 1, currColIndex + 1] -= currBombValue;
                    }
                }
            }

            int aliveCells = 0;
            int sum = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (bombField[row, col] > 0)
                    {
                        aliveCells++;
                        sum += bombField[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(bombField[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool IsIndexValid(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}

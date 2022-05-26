using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                jaggedArray[row] = elements;
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = cmd.Split(" ");

                string cmdType = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                if (!IsValid(row, col, jaggedArray))
                {
                    continue;
                }
                else
                {
                    if (cmdType == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (cmdType == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
        }

        public static bool IsValid (int row, int col, int[][] jaggedArray)
        {
            if (row >= 0 && row < jaggedArray.GetLength(0) && col >= 0 && col < jaggedArray[row].Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;

namespace TruffleHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] currentRowElements = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currentRowElements[col];
                }
            }

            int blackTrufflesCount = 0;
            int summerTrufflesCount = 0;
            int whiteTrufflesCount = 0;
            int eatenTrufflesCount = 0;

            string command;
            while ((command = Console.ReadLine()) != "Stop the hunt")
            {
                string type = command.Split()[0];
                int currRow = int.Parse(command.Split()[1]);
                int currCol = int.Parse(command.Split()[2]);

                if (type == "Collect")
                {
                    char currTruffle = matrix[currRow, currCol];
                    matrix[currRow, currCol] = '-';

                    if (currTruffle == 'B')
                    {
                        blackTrufflesCount++;
                    }
                    else if (currTruffle == 'S')
                    {
                        summerTrufflesCount++;
                    }
                    else if (currTruffle == 'W')
                    {
                        whiteTrufflesCount++;
                    }
                }
                else if (type == "Wild_Boar")
                {
                    string direction = command.Split()[3];

                    if (direction == "up")
                    {
                        while (IsRowValid(currRow, size))
                        {
                            if (IsEatenTruffle(currRow, currCol, matrix))
                            {
                                eatenTrufflesCount++;
                            }
                            currRow -= 2;
                        }
                    }
                    else if (direction == "down")
                    {
                        while (IsRowValid(currRow, size))
                        {
                            if (IsEatenTruffle(currRow, currCol, matrix))
                            {
                                eatenTrufflesCount++;
                            }
                            currRow += 2;
                        }
                    }
                    else if (direction == "left")
                    {
                        while (IsColValid(currCol, size))
                        {
                            if (IsEatenTruffle(currRow, currCol, matrix))
                            {
                                eatenTrufflesCount++;
                            }
                            currCol -= 2;
                        }
                    }
                    else if (direction == "right")
                    {
                        while (IsColValid(currCol, size))
                        {
                            if (IsEatenTruffle(currRow, currCol, matrix))
                            {
                                eatenTrufflesCount++;
                            }
                            currCol += 2;
                        }
                    }
                }
            }

            Console.WriteLine($"Peter manages to harvest {blackTrufflesCount} black, {summerTrufflesCount} summer, and {whiteTrufflesCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eatenTrufflesCount} truffles.");

            PrintMatrix(matrix);
        }

        private static bool IsRowValid(int currRow, int size)
        {
            return currRow >= 0 && currRow < size;
        }

        private static bool IsColValid(int currCol, int size)
        {
            return currCol >= 0 && currCol < size;
        }

        private static bool IsEatenTruffle(int currRow, int currCol, char[,] matrix)
        {
            char currPositionChar = matrix[currRow, currCol];

            if (currPositionChar == 'B' || currPositionChar == 'S' || currPositionChar == 'W')
            {
                matrix[currRow, currCol] = '-';
                return true;
            }
            return false;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

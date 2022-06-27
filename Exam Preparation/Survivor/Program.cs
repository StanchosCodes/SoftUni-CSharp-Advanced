using System;
using System.Linq;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] beach = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                char[] currRowChars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                beach[row] = currRowChars;
            }

            int tokensCount = 0;
            int oponentsTokensCount = 0;

            string command;
            while ((command = Console.ReadLine()) != "Gong")
            {
                string type = command.Split()[0];
                int currRow = int.Parse(command.Split()[1]);
                int currCol = int.Parse(command.Split()[2]);

                if (type == "Find")
                {
                    if (!IsValid(currRow, currCol, beach))
                    {
                        continue;
                    }
                    if (beach[currRow][currCol] == 'T')
                    {
                        tokensCount++;
                        beach[currRow][currCol] = '-';
                    }
                }
                else if (type == "Opponent")
                {
                    string direction = command.Split()[3];

                    if (!IsValid(currRow, currCol, beach))
                    {
                        continue;
                    }
                    if (beach[currRow][currCol] == 'T')
                    {
                        oponentsTokensCount++;
                        beach[currRow][currCol] = '-';
                    }
                    for (int i = 1; i <= 3; i++)
                    {
                        if (direction == "up")
                        {
                            if (!IsValid(currRow - i, currCol, beach))
                            {
                                continue;
                            }

                            if (beach[currRow - i][currCol] == 'T')
                            {
                                oponentsTokensCount++;
                                beach[currRow - i][currCol] = '-';
                            }
                        }
                        else if (direction == "down")
                        {
                            if (!IsValid(currRow + i, currCol, beach))
                            {
                                continue;
                            }

                            if (beach[currRow + i][currCol] == 'T')
                            {
                                oponentsTokensCount++;
                                beach[currRow + i][currCol] = '-';
                            }
                        }
                        else if (direction == "left")
                        {
                            if (!IsValid(currRow, currCol - i, beach))
                            {
                                continue;
                            }

                            if (beach[currRow][currCol - i] == 'T')
                            {
                                oponentsTokensCount++;
                                beach[currRow][currCol - i] = '-';
                            }
                        }
                        else if (direction == "right")
                        {
                            if (!IsValid(currRow, currCol + i, beach))
                            {
                                continue;
                            }

                            if (beach[currRow][currCol + i] == 'T')
                            {
                                oponentsTokensCount++;
                                beach[currRow][currCol + i] = '-';
                            }
                        }
                    }
                }
            }

            PrintBeach(beach);
            Console.WriteLine($"Collected tokens: {tokensCount}");
            Console.WriteLine($"Opponent's tokens: {oponentsTokensCount}");
        }

        private static bool IsValid(int row, int col, char[][] beach)
        {
            if (row >= 0 && row < beach.GetLength(0) && col >= 0 && col < beach[row].Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void PrintBeach(char[][] beach)
        {
            for (int row = 0; row < beach.GetLength(0); row++)
            {
                for (int col = 0; col < beach[row].Length; col++)
                {
                    Console.Write(beach[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
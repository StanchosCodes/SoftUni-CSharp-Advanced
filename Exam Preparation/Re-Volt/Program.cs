//using System;

//namespace Re_Volt
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int size = int.Parse(Console.ReadLine());
//            int numCommands = int.Parse(Console.ReadLine());

//            int playerRow = 0;
//            int playerCol = 0;

//            char[,] map = new char[size, size];

//            for (int row = 0; row < size; row++)
//            {
//                char[] inputLine = Console.ReadLine().ToCharArray();

//                for (int col = 0; col < size; col++)
//                {
//                    map[row, col] = inputLine[col];

//                    if (map[row, col] == 'f')
//                    {
//                        playerRow = row;
//                        playerCol = col;
//                    }
//                }
//            }

//            bool isFinished = false;

//            for (int i = 0; i < numCommands; i++)
//            {
//                string direction = Console.ReadLine();

//                if (direction == "up")
//                {
//                    if (IsValid(map, playerRow - 1, playerCol))
//                    {
//                        map[playerRow, playerCol] = '-';
//                        playerRow--;

//                        if (map[playerRow, playerCol] == 'B')
//                        {
//                            if (IsValid(map, playerRow - 1, playerCol))
//                            {
//                                playerRow--;
//                                if (map[playerRow, playerCol] == 'F')
//                                {
//                                    map[playerRow, playerCol] = 'f';
//                                    isFinished = true;
//                                }
//                                else
//                                {
//                                    map[playerRow, playerCol] = 'f';
//                                }
//                            }
//                            else
//                            {
//                                playerRow = map.GetLength(0) - 1;

//                                if (map[playerRow, playerCol] == 'F')
//                                {
//                                    map[playerRow, playerCol] = 'f';
//                                    isFinished = true;
//                                }
//                                map[playerRow, playerCol] = 'f';
//                            }
//                        }
//                        else if (map[playerRow, playerCol] == 'T')
//                        {
//                            playerRow++;
//                            map[playerRow, playerCol] = 'f';
//                        }
//                        else if (map[playerRow, playerCol] == 'F')
//                        {
//                            map[playerRow, playerCol] = 'f';
//                            isFinished = true;
//                        }
//                        else
//                        {
//                            map[playerRow, playerCol] = 'f';
//                        }
//                    }
//                    else
//                    {
//                        map[playerRow, playerCol] = '-';
//                        playerRow = map.GetLength(0) - 1;

//                        if (map[playerRow, playerCol] == 'F')
//                        {
//                            map[playerRow, playerCol] = 'f';
//                            isFinished = true;
//                        }
//                        else if (map[playerRow, playerCol] == 'T')
//                        {
//                            playerRow = 0;
//                        }
//                        map[playerRow, playerCol] = 'f';
//                    }
//                }
//                else if (direction == "down")
//                {
//                    if (IsValid(map, playerRow + 1, playerCol))
//                    {
//                        map[playerRow, playerCol] = '-';
//                        playerRow++;

//                        if (map[playerRow, playerCol] == 'B')
//                        {
//                            if (IsValid(map, playerRow + 1, playerCol))
//                            {
//                                playerRow++;
//                                if (map[playerRow, playerCol] == 'F')
//                                {
//                                    map[playerRow, playerCol] = 'f';
//                                    isFinished = true;
//                                }
//                                else
//                                {
//                                    map[playerRow, playerCol] = 'f';
//                                }
//                            }
//                            else
//                            {
//                                playerRow = 0;

//                                if (map[playerRow, playerCol] == 'F')
//                                {
//                                    map[playerRow, playerCol] = 'f';
//                                    isFinished = true;
//                                }
//                                map[playerRow, playerCol] = 'f';
//                            }
//                        }
//                        else if (map[playerRow, playerCol] == 'T')
//                        {
//                            playerRow--;
//                            map[playerRow, playerCol] = 'f';
//                        }
//                        else if (map[playerRow, playerCol] == 'F')
//                        {
//                            map[playerRow, playerCol] = 'f';
//                            isFinished = true;
//                        }
//                        else
//                        {
//                            map[playerRow, playerCol] = 'f';
//                        }
//                    }
//                    else
//                    {
//                        map[playerRow, playerCol] = '-';
//                        playerRow = 0;

//                        if (map[playerRow, playerCol] == 'F')
//                        {
//                            map[playerRow, playerCol] = 'f';
//                            isFinished = true;
//                        }
//                        else if (map[playerRow, playerCol] == 'T')
//                        {
//                            playerRow = size - 1;
//                        }
//                        map[playerRow, playerCol] = 'f';
//                    }
//                }
//                else if (direction == "left")
//                {
//                    if (IsValid(map, playerRow, playerCol - 1))
//                    {
//                        map[playerRow, playerCol] = '-';
//                        playerCol--;

//                        if (map[playerRow, playerCol] == 'B')
//                        {
//                            if (IsValid(map, playerRow, playerCol - 1))
//                            {
//                                playerCol--;
//                                if (map[playerRow, playerCol] == 'F')
//                                {
//                                    map[playerRow, playerCol] = 'f';
//                                    isFinished = true;
//                                }
//                                else
//                                {
//                                    map[playerRow, playerCol] = 'f';
//                                }
//                            }
//                            else
//                            {
//                                playerCol = map.GetLength(0) - 1;

//                                if (map[playerRow, playerCol] == 'F')
//                                {
//                                    map[playerRow, playerCol] = 'f';
//                                    isFinished = true;
//                                }
//                                map[playerRow, playerCol] = 'f';
//                            }
//                        }
//                        else if (map[playerRow, playerCol] == 'T')
//                        {
//                            playerCol++;
//                            map[playerRow, playerCol] = 'f';
//                        }
//                        else if (map[playerRow, playerCol] == 'F')
//                        {
//                            map[playerRow, playerCol] = 'f';
//                            isFinished = true;
//                        }
//                        else
//                        {
//                            map[playerRow, playerCol] = 'f';
//                        }
//                    }
//                    else
//                    {
//                        map[playerRow, playerCol] = '-';
//                        playerCol = map.GetLength(0) - 1;

//                        if (map[playerRow, playerCol] == 'F')
//                        {
//                            map[playerRow, playerCol] = 'f';
//                            isFinished = true;
//                        }
//                        else if (map[playerRow, playerCol] == 'T')
//                        {
//                            playerCol = 0;
//                        }
//                        map[playerRow, playerCol] = 'f';
//                    }
//                }
//                else if (direction == "right")
//                {
//                    if (IsValid(map, playerRow, playerCol + 1))
//                    {
//                        map[playerRow, playerCol] = '-';
//                        playerCol++;

//                        if (map[playerRow, playerCol] == 'B')
//                        {
//                            if (IsValid(map, playerRow, playerCol + 1))
//                            {
//                                playerCol++;
//                                if (map[playerRow, playerCol] == 'F')
//                                {
//                                    map[playerRow, playerCol] = 'f';
//                                    isFinished = true;
//                                }
//                                else
//                                {
//                                    map[playerRow, playerCol] = 'f';
//                                }
//                            }
//                            else
//                            {
//                                playerCol = 0;

//                                if (map[playerRow, playerCol] == 'F')
//                                {
//                                    map[playerRow, playerCol] = 'f';
//                                    isFinished = true;
//                                }
//                                map[playerRow, playerCol] = 'f';
//                            }
//                        }
//                        else if (map[playerRow, playerCol] == 'T')
//                        {
//                            playerCol--;
//                            map[playerRow, playerCol] = 'f';
//                        }
//                        else if (map[playerRow, playerCol] == 'F')
//                        {
//                            map[playerRow, playerCol] = 'f';
//                            isFinished = true;
//                        }
//                        else
//                        {
//                            map[playerRow, playerCol] = 'f';
//                        }
//                    }
//                    else
//                    {
//                        map[playerRow, playerCol] = '-';
//                        playerCol = 0;

//                        if (map[playerRow, playerCol] == 'F')
//                        {
//                            map[playerRow, playerCol] = 'f';
//                            isFinished = true;
//                        }
//                        else if (map[playerRow, playerCol] == 'T')
//                        {
//                            playerCol = size - 1;
//                        }
//                        map[playerRow, playerCol] = 'f';
//                    }
//                }

//                if (isFinished)
//                {
//                    break;
//                }
//            }

//            if (isFinished)
//            {
//                Console.WriteLine("Player won!");
//            }
//            else
//            {
//                Console.WriteLine("Player lost!");
//            }

//            PrintMatrix(map);
//        }

//        private static bool IsValid(char[,] matrix, int playerRow, int playerCol)
//        {
//            return playerRow >= 0 && playerCol < matrix.GetLength(0) && playerCol >= 0 && playerCol < matrix.GetLength(1);
//        }

//        private static void PrintMatrix(char[,] matrix)
//        {
//            for (int row = 0; row < matrix.GetLength(0); row++)
//            {
//                for (int col = 0; col < matrix.GetLength(1); col++)
//                {
//                    Console.Write(matrix[row, col]);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//} runtime at test 6 => 90/100

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LooBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int numberOfCommand = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];

            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < size; row++)
            {
                string data = Console.ReadLine();

                matrix[row] = new char[data.Length];

                for (int col = 0; col < data.Length; col++)
                {
                    matrix[row][col] = data[col];

                    if (data[col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;

                    }
                }
            }

            bool wonTheGame = false;

            for (int i = 0; i < numberOfCommand; i++)
            {
                string command = Console.ReadLine();

                matrix[playerRow][playerCol] = '-';

                if (command == "up")
                {
                    if (playerRow - 1 >= 0)
                    {
                        playerRow--;
                    }
                    else
                    {
                        playerRow = matrix.Length - 1;
                    }

                    while (matrix[playerRow][playerCol] != '-' && matrix[playerRow][playerCol] != 'F')
                    {


                        if (matrix[playerRow][playerCol] == 'T')
                        {
                            playerRow++;
                        }
                        else if (matrix[playerRow][playerCol] == 'B')
                        {
                            playerRow--;
                        }

                        if (playerRow < 0)
                        {
                            playerRow = matrix.Length - 1;
                        }

                    }

                    if (matrix[playerRow][playerCol] == 'F')
                    {
                        wonTheGame = true;
                        break;
                    }

                    matrix[playerRow][playerCol] = 'f';

                    //Print(matrix);

                }
                else if (command == "down")
                {
                    if (playerRow + 1 < matrix.Length)
                    {
                        playerRow++;
                    }
                    else
                    {
                        playerRow = 0;
                    }

                    while (matrix[playerRow][playerCol] != '-' && matrix[playerRow][playerCol] != 'F')
                    {

                        if (matrix[playerRow][playerCol] == 'T')
                        {
                            playerRow--;
                        }
                        else if (matrix[playerRow][playerCol] == 'B')
                        {
                            playerRow++;
                        }

                        if (playerRow == matrix.Length)
                        {
                            playerRow = 0;
                        }
                    }

                    if (matrix[playerRow][playerCol] == 'F')
                    {
                        wonTheGame = true;
                        break;
                    }

                    matrix[playerRow][playerCol] = 'f';

                    //Print(matrix);

                }
                else if (command == "right")
                {
                    if (playerCol + 1 < matrix.Length)
                    {
                        playerCol++;
                    }
                    else
                    {
                        playerCol = 0;
                    }

                    while (matrix[playerRow][playerCol] != '-' && matrix[playerRow][playerCol] != 'F')
                    {
                        if (matrix[playerRow][playerCol] == 'T')
                        {
                            playerCol--;
                        }
                        else if (matrix[playerRow][playerCol] == 'B')
                        {
                            playerCol++;
                        }

                        if (playerRow == matrix.Length)
                        {
                            playerRow = 0;
                        }
                    }

                    if (matrix[playerRow][playerCol] == 'F')
                    {
                        wonTheGame = true;
                        break;
                    }

                    matrix[playerRow][playerCol] = 'f';

                    //Print(matrix);

                }
                else if (command == "left")
                {
                    if (playerCol - 1 >= 0)
                    {
                        playerCol--;
                    }
                    else
                    {
                        playerCol = matrix.Length - 1;
                    }

                    while (matrix[playerRow][playerCol] != '-' && matrix[playerRow][playerCol] != 'F')
                    {
                        if (playerCol < 0)
                        {
                            playerCol = matrix.Length - 1;
                        }

                        if (matrix[playerRow][playerCol] == 'T')
                        {
                            playerCol++;
                        }
                        else if (matrix[playerRow][playerCol] == 'B')
                        {
                            playerCol--;
                        }

                        if (playerCol < 0)
                        {
                            playerCol = matrix.Length - 1;
                        }
                    }

                    if (matrix[playerRow][playerCol] == 'F')
                    {
                        wonTheGame = true;
                        break;
                    }

                    matrix[playerRow][playerCol] = 'f';

                    //Print(matrix);
                }
            }

            if (wonTheGame)
            {
                matrix[playerRow][playerCol] = 'f';

                Console.WriteLine($"Player won!");
            }
            else
            {
                Console.WriteLine($"Player lost!");
            }

            Print(matrix);
        }


        private static void Print(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }

                Console.WriteLine();
            }
        }

    }
}
using System;

namespace WallDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] wall = new char[size, size];
            int holeCount = 1;
            int rodsCount = 0;
            int vankosRow = 0;
            int vankosCol = 0;

            for (int row = 0; row < size; row++)
            {
                char[] inputLine = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    wall[row, col] = inputLine[col];

                    if (wall[row, col] == 'V')
                    {
                        vankosRow = row;
                        vankosCol = col;
                    }
                }
            }

            string direction;
            while ((direction = Console.ReadLine()) != "End")
            {
                if (direction == "up")
                {
                    if (vankosRow - 1 >= 0)
                    {
                        wall[vankosRow, vankosCol] = '*';
                        vankosRow--;
                        if (wall[vankosRow, vankosCol] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            rodsCount++;
                            vankosRow++;
                            wall[vankosRow, vankosCol] = 'V';
                        }
                        else if (wall[vankosRow, vankosCol] == 'C')
                        {
                            wall[vankosRow, vankosCol] = 'E';
                            holeCount++;
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCount} hole(s).");
                            PrintMatrix(wall);
                            return;
                        }
                        else if (wall[vankosRow, vankosCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{vankosRow}, {vankosCol}]!");
                        }
                        else
                        {
                            wall[vankosRow, vankosCol] = 'V';
                            holeCount++;
                        }
                    }
                }
                else if (direction == "down")
                {
                    if (vankosRow + 1 < size)
                    {
                        wall[vankosRow, vankosCol] = '*';
                        vankosRow++;
                        if (wall[vankosRow, vankosCol] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            rodsCount++;
                            vankosRow--;
                            wall[vankosRow, vankosCol] = 'V';
                        }
                        else if (wall[vankosRow, vankosCol] == 'C')
                        {
                            wall[vankosRow, vankosCol] = 'E';
                            holeCount++;
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCount} hole(s).");
                            PrintMatrix(wall);
                            return;
                        }
                        else if (wall[vankosRow, vankosCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{vankosRow}, {vankosCol}]!");
                        }
                        else
                        {
                            wall[vankosRow, vankosCol] = 'V';
                            holeCount++;
                        }
                    }
                }
                else if (direction == "left")
                {
                    if (vankosCol - 1 >= 0)
                    {
                        wall[vankosRow, vankosCol] = '*';
                        vankosCol--;
                        if (wall[vankosRow, vankosCol] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            rodsCount++;
                            vankosCol++;
                            wall[vankosRow, vankosCol] = 'V';
                        }
                        else if (wall[vankosRow, vankosCol] == 'C')
                        {
                            wall[vankosRow, vankosCol] = 'E';
                            holeCount++;
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCount} hole(s).");
                            PrintMatrix(wall);
                            return;
                        }
                        else if (wall[vankosRow, vankosCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{vankosRow}, {vankosCol}]!");
                        }
                        else
                        {
                            wall[vankosRow, vankosCol] = 'V';
                            holeCount++;
                        }
                    }
                }
                else if (direction == "right")
                {
                    if (vankosCol + 1 < size)
                    {
                        wall[vankosRow, vankosCol] = '*';
                        vankosCol++;
                        if (wall[vankosRow, vankosCol] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            rodsCount++;
                            vankosCol--;
                            wall[vankosRow, vankosCol] = 'V';
                        }
                        else if (wall[vankosRow, vankosCol] == 'C')
                        {
                            wall[vankosRow, vankosCol] = 'E';
                            holeCount++;
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCount} hole(s).");
                            PrintMatrix(wall);
                            return;
                        }
                        else if (wall[vankosRow, vankosCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{vankosRow}, {vankosCol}]!");
                            wall[vankosRow, vankosCol] = 'V';
                        }
                        else
                        {
                            wall[vankosRow, vankosCol] = 'V';
                            holeCount++;
                        }
                    }
                }
            }
            Console.WriteLine($"Vanko managed to make {holeCount} hole(s) and he hit only {rodsCount} rod(s).");
            PrintMatrix(wall);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

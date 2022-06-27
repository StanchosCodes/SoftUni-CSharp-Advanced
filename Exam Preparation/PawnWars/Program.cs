using System;
using System.Linq;

namespace PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string capturePosition = string.Empty;

            char colPosition = ' ';
            int rowPosition = 0;
            int size = 8;

            int bRowPosition = 0;
            int bColPosition = 0;
            int wRowPosition = 0;
            int wColPosition = 0;

            char[,] board = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] currRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    board[row, col] = currRow[col];
                    if (board[row, col] == 'b')
                    {
                        bRowPosition = row;
                        bColPosition = col;
                    }
                    if (board[row, col] == 'w')
                    {
                        wRowPosition = row;
                        wColPosition = col;
                    }
                }
            }

            while (true)
            {
                // White's turn
                int tempLeftWColPosition = wColPosition;
                int tempRightWColPosition = wColPosition;
                if (tempLeftWColPosition - 1 >= 0)
                {
                    tempLeftWColPosition -= 1;
                }
                if (tempRightWColPosition + 1 < size)
                {
                    tempRightWColPosition++;
                }

                if (board[wRowPosition - 1, tempLeftWColPosition] == 'b' ||
                    board[wRowPosition - 1, tempRightWColPosition] == 'b')
                {
                    rowPosition = size - bRowPosition;
                    colPosition = (bColPosition == 0 ? 'a' : bColPosition == 1 ? 'b' : bColPosition == 2 ? 'c' : bColPosition == 3 ? 'd' : bColPosition == 4 ? 'e' : bColPosition == 5 ? 'f' : bColPosition == 6 ? 'g' : 'h');

                    capturePosition = $"{colPosition}{rowPosition}";
                    Console.WriteLine($"Game over! White capture on {capturePosition}.");
                    break;
                }
                else
                {
                    board[wRowPosition, wColPosition] = '-';
                    wRowPosition--;
                    board[wRowPosition, wColPosition] = 'w';

                    if (wRowPosition == 0)
                    {
                        rowPosition = size - wRowPosition;
                        colPosition = (wColPosition == 0 ? 'a' : wColPosition == 1 ? 'b' : wColPosition == 2 ? 'c' : wColPosition == 3 ? 'd' : wColPosition == 4 ? 'e' : wColPosition == 5 ? 'f' : wColPosition == 6 ? 'g' : 'h');

                        capturePosition = $"{colPosition}{rowPosition}";
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {capturePosition}.");
                        break;
                    }
                }

                // Black's turn
                int tempLeftBColPosition = bColPosition;
                int tempRightBColPosition = bColPosition;
                if (tempLeftBColPosition - 1 >= 0)
                {
                    tempLeftBColPosition -= 1;
                }
                if (tempRightBColPosition + 1 < size)
                {
                    tempRightBColPosition++;
                }

                if (board[bRowPosition + 1, tempLeftBColPosition] == 'w' ||
                    board[bRowPosition + 1, tempRightBColPosition] == 'w')
                {
                    rowPosition = size - wRowPosition;
                    colPosition = (wColPosition == 0 ? 'a' : wColPosition == 1 ? 'b' : wColPosition == 2 ? 'c' : wColPosition == 3 ? 'd' : wColPosition == 4 ? 'e' : wColPosition == 5 ? 'f' : wColPosition == 6 ? 'g' : 'h');

                    capturePosition = $"{colPosition}{rowPosition}";
                    Console.WriteLine($"Game over! Black capture on {capturePosition}.");
                    break;
                }
                else
                {
                    board[bRowPosition, bColPosition] = '-';
                    bRowPosition++;
                    board[bRowPosition, bColPosition] = 'b';

                    if (bRowPosition == size - 1)
                    {
                        rowPosition = size - bRowPosition;
                        colPosition = (bColPosition == 0 ? 'a' : bColPosition == 1 ? 'b' : bColPosition == 2 ? 'c' : bColPosition == 3 ? 'd' : bColPosition == 4 ? 'e' : bColPosition == 5 ? 'f' : bColPosition == 6 ? 'g' : 'h');

                        capturePosition = $"{colPosition}{rowPosition}";
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {capturePosition}.");
                        break;
                    }
                }
            }
        }
    }
}

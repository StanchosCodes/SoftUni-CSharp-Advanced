using System;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()); // Reading the size of the matrix

            (int rows, int cols) = (size, size);

            char[,] board = new char[rows, cols];

            for (int row = 0; row < rows; row++) // Filling the matrix
            {
                string currInputRow = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    board[row, col] = currInputRow[col];
                }
            }

            int removedKnights = 0;

            while (true)
            {
                // Checking for the K's collusion 
                int maxAttackingKnight = 0;
                int currRow = -1;
                int currCol = -1;

                // Posible attack cases
                // 1 row up 2 cols to the left
                // 1 row up 2 cols to the right
                // 2 rows up 1 col to the left
                // 2 rows up 1 col to the right
                // 2 rows down 1 col to the left
                // 2 rows down 1 col to the right
                // 1 row down 2 cols to the left
                // 1 row down 2 cols to the right

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        int currAttacks = 0;

                        if (board[row, col] == '0')
                        {
                            continue;
                        }

                        if (IsIndexValid(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K') // 1 row up and 2 cols to the left 
                        {
                            currAttacks++;
                        }
                        if (IsIndexValid(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K') // 1 row up 2 cols to the right
                        {
                            currAttacks++;
                        }
                        if (IsIndexValid(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K') // 2 rows up 1 col to the left
                        {
                            currAttacks++;
                        }
                        if (IsIndexValid(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K') // 2 rows up 1 col to the right
                        {
                            currAttacks++;
                        }
                        if (IsIndexValid(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K') // 2 rows down 1 col to the left
                        {
                            currAttacks++;
                        }
                        if (IsIndexValid(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K') // 2 rows down 1 col to the right
                        {
                            currAttacks++;
                        }
                        if (IsIndexValid(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K') // 1 row down 2 cols to the left
                        {
                            currAttacks++;
                        }
                        if (IsIndexValid(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K') // 1 row down 2 cols to the right
                        {
                            currAttacks++;
                        }

                        //Checking if this attacking knight is with max matching attacks
                        if (currAttacks > maxAttackingKnight)
                        {
                            maxAttackingKnight = currAttacks;
                            currRow = row;
                            currCol = col;
                        }
                    }
                }

                if (maxAttackingKnight > 0)
                {
                    board[currRow, currCol] = '0';
                    removedKnights++;
                }
                else
                {
                    Console.WriteLine(removedKnights);
                    break;
                }
            }
        }

        // Checking if the current indices are in the matrix
        public static bool IsIndexValid(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1);
        }
    }
}

using System;

namespace Armory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] armory = new char[size, size];

            int mirror1Row = 0;
            int mirror1Col = 0;
            int mirror2Row = 0;
            int mirror2Col = 0;
            int mirrorCount = 0;
            int officerRow = 0;
            int officerCol = 0;
            int spendMoney = 0;
            bool isLeft = false;

            for (int row = 0; row < size; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    armory[row, col] = input[col];
                    if (armory[row, col] == 'M')
                    {
                        if (mirrorCount == 0)
                        {
                            mirror1Row = row;
                            mirror1Col = col;

                            mirrorCount++;
                        }
                        else if (mirrorCount > 0)
                        {
                            mirror2Row = row;
                            mirror2Col = col;

                            mirrorCount++;
                        }
                    }
                    if (armory[row, col] == 'A')
                    {
                        officerRow = row;
                        officerCol = col;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    if (!IsValidIndex(officerRow - 1, officerCol, size))
                    {
                        armory[officerRow, officerCol] = '-';
                        isLeft = true;
                        break;
                    }
                    else
                    {
                        armory[officerRow, officerCol] = '-';
                        if (armory[officerRow - 1, officerCol] != '-' && armory[officerRow - 1, officerCol] != 'M')
                        {
                            int price = (int)armory[officerRow - 1, officerCol] - 48;
                            spendMoney += price;
                            officerRow--;
                            armory[officerRow, officerCol] = 'A';
                        }
                        else if (armory[officerRow - 1, officerCol] == 'M')
                        {
                            armory[officerRow - 1, officerCol] = '-';

                            if (officerRow - 1 == mirror1Row && officerCol == mirror1Col)
                            {
                                officerRow = mirror2Row;
                                officerCol = mirror2Col;
                                armory[officerRow, officerCol] = 'A';
                            }
                            else
                            {
                                officerRow = mirror1Row;
                                officerCol = mirror1Col;
                                armory[officerRow, officerCol] = 'A';
                            }
                        }
                        else
                        {
                            officerRow--;
                        }
                    }
                }
                else if (command == "down")
                {
                    if (!IsValidIndex(officerRow + 1, officerCol, size))
                    {
                        armory[officerRow, officerCol] = '-';
                        isLeft = true;
                        break;
                    }
                    else
                    {
                        armory[officerRow, officerCol] = '-';
                        if (armory[officerRow + 1, officerCol] != '-' && armory[officerRow + 1, officerCol] != 'M')
                        {
                            int price = (int)armory[officerRow + 1, officerCol] - 48;
                            spendMoney += price;
                            officerRow++;
                            armory[officerRow, officerCol] = 'A';
                        }
                        else if (armory[officerRow + 1, officerCol] == 'M')
                        {
                            armory[officerRow + 1, officerCol] = '-';

                            if (officerRow + 1 == mirror1Row && officerCol == mirror1Col)
                            {
                                officerRow = mirror2Row;
                                officerCol = mirror2Col;
                                armory[officerRow, officerCol] = 'A';
                            }
                            else
                            {
                                officerRow = mirror1Row;
                                officerCol = mirror1Col;
                                armory[officerRow, officerCol] = 'A';
                            }
                        }
                        else
                        {
                            officerRow++;
                        }
                    }
                }
                else if (command == "left")
                {
                    if (!IsValidIndex(officerRow, officerCol - 1, size))
                    {
                        armory[officerRow, officerCol] = '-';
                        isLeft = true;
                        break;
                    }
                    else
                    {
                        armory[officerRow, officerCol] = '-';
                        if (armory[officerRow, officerCol - 1] != '-' && armory[officerRow, officerCol - 1] != 'M')
                        {
                            int price = (int)armory[officerRow, officerCol - 1] - 48;
                            spendMoney += price;
                            officerCol--;
                            armory[officerRow, officerCol] = 'A';
                        }
                        else if (armory[officerRow, officerCol - 1] == 'M')
                        {
                            armory[officerRow, officerCol - 1] = '-';

                            if (officerRow == mirror1Row && officerCol - 1 == mirror1Col)
                            {
                                officerRow = mirror2Row;
                                officerCol = mirror2Col;
                                armory[officerRow, officerCol] = 'A';
                            }
                            else
                            {
                                officerRow = mirror1Row;
                                officerCol = mirror1Col;
                                armory[officerRow, officerCol] = 'A';
                            }
                        }
                        else
                        {
                            officerCol--;
                        }
                    }
                }
                else if (command == "right")
                {
                    if (!IsValidIndex(officerRow, officerCol + 1, size))
                    {
                        armory[officerRow, officerCol] = '-';
                        isLeft = true;
                        break;
                    }
                    else
                    {
                        armory[officerRow, officerCol] = '-';
                        if (armory[officerRow, officerCol + 1] != '-' && armory[officerRow, officerCol + 1] != 'M')
                        {
                            int price = (int)armory[officerRow, officerCol + 1] - 48;
                            spendMoney += price;
                            officerCol++;
                            armory[officerRow, officerCol] = 'A';
                        }
                        else if (armory[officerRow, officerCol + 1] == 'M')
                        {
                            armory[officerRow, officerCol + 1] = '-';

                            if (officerRow == mirror1Row && officerCol + 1 == mirror1Col)
                            {
                                officerRow = mirror2Row;
                                officerCol = mirror2Col;
                                armory[officerRow, officerCol] = 'A';
                            }
                            else
                            {
                                officerRow = mirror1Row;
                                officerCol = mirror1Col;
                                armory[officerRow, officerCol] = 'A';
                            }
                        }
                        else
                        {
                            officerCol++;
                        }
                    }
                }

                if (spendMoney >= 65)
                {
                    break;
                }
            }
            if (isLeft)
            {
                Console.WriteLine("I do not need more swords!");
            }
            if (spendMoney >= 65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
            }

            Console.WriteLine($"The king paid {spendMoney} gold coins. ");
            PrintMatrix(armory);
        }

        private static bool IsValidIndex(int row, int col, int size)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
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

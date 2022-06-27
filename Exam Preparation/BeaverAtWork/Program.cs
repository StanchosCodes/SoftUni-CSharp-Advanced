using System;
using System.Collections.Generic;
using System.Linq;

namespace BeaverAtWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] pond = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] values = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    pond[row, col] = values[col];
                }
            }

            int[] beaverIndeces = new int[2] { -1, -1 };
            bool isBeaverFound = false;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (pond[row, col] == 'B')
                    {
                        beaverIndeces[0] = row;
                        beaverIndeces[1] = col;
                        isBeaverFound = true;
                        break;
                    }
                }
                if (isBeaverFound)
                {
                    break;
                }
            }

            int currRow = beaverIndeces[0];
            int currCol = beaverIndeces[1];

            Stack<char> branches = new Stack<char>();
            int countBranches = 0;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "up")
                {
                    if (currRow - 1 >= 0)
                    {
                        pond[currRow, currCol] = '-';
                        currRow -= 1;

                        if (pond[currRow, currCol] == 'F')
                        {
                            pond[currRow, currCol] = '-';

                            if (currRow > 0)
                            {
                                for (int row = currRow; row >= 0; row--)
                                {
                                    currRow = row;
                                }

                                if (Char.IsLower(pond[currRow, currCol]))
                                {
                                    branches.Push(pond[currRow, currCol]);
                                }
                            }
                            else if (currRow == 0)
                            {
                                for (int row = currRow; row < size; row++)
                                {
                                    currRow = row;
                                }

                                if (Char.IsLower(pond[currRow, currCol]))
                                {
                                    branches.Push(pond[currRow, currCol]);
                                }
                            }
                            pond[currRow, currCol] = 'B';
                        }
                        else if (char.IsLower(pond[currRow, currCol]))
                        {
                            branches.Push(pond[currRow, currCol]);
                            pond[currRow, currCol] = 'B';
                        }
                        else
                        {
                            pond[currRow, currCol] = 'B';
                        }
                    }
                    else
                    {
                        if (branches.Count > 0)
                        {
                            branches.Pop();
                        }
                    }
                }
                else if (command == "down")
                {
                    if (currRow + 1 < size)
                    {
                        pond[currRow, currCol] = '-';
                        currRow += 1;

                        if (pond[currRow, currCol] == 'F')
                        {
                            pond[currRow, currCol] = '-';

                            if (currRow == size - 1)
                            {
                                for (int row = currRow; row >= 0; row--)
                                {
                                    currRow = row;
                                }

                                if (Char.IsLower(pond[currRow, currCol]))
                                {
                                    branches.Push(pond[currRow, currCol]);
                                }
                            }
                            else if (currRow < size - 1)
                            {
                                for (int row = currRow; row < size; row++)
                                {
                                    currRow = row;
                                }

                                if (Char.IsLower(pond[currRow, currCol]))
                                {
                                    branches.Push(pond[currRow, currCol]);
                                }
                            }
                            pond[currRow, currCol] = 'B';
                        }
                        else if (char.IsLower(pond[currRow, currCol]))
                        {
                            branches.Push(pond[currRow, currCol]);
                            pond[currRow, currCol] = 'B';
                        }
                        else
                        {
                            pond[currRow, currCol] = 'B';
                        }
                    }
                    else
                    {
                        if (branches.Count > 0)
                        {
                            branches.Pop();
                        }
                    }
                }
                else if (command == "left")
                {
                    if (currCol - 1 >= 0)
                    {
                        pond[currRow, currCol] = '-';
                        currCol -= 1;

                        if (pond[currRow, currCol] == 'F')
                        {
                            pond[currRow, currCol] = '-';

                            if (currCol > 0)
                            {
                                for (int col = currCol; col >= 0; col--)
                                {
                                    currCol = col;
                                }

                                if (Char.IsLower(pond[currRow, currCol]))
                                {
                                    branches.Push(pond[currRow, currCol]);
                                }
                            }
                            else if (currCol == 0)
                            {
                                for (int col = currCol; col < size; col++)
                                {
                                    currCol = col;
                                }

                                if (Char.IsLower(pond[currRow, currCol]))
                                {
                                    branches.Push(pond[currRow, currCol]);
                                }
                            }
                            pond[currRow, currCol] = 'B';
                        }
                        else if (char.IsLower(pond[currRow, currCol]))
                        {
                            branches.Push(pond[currRow, currCol]);
                            pond[currRow, currCol] = 'B';
                        }
                        else
                        {
                            pond[currRow, currCol] = 'B';
                        }
                    }
                    else
                    {
                        if (branches.Count > 0)
                        {
                            branches.Pop();
                        }
                    }
                }
                else if (command == "right")
                {
                    if (currCol + 1 < size)
                    {
                        pond[currRow, currCol] = '-';
                        currCol += 1;

                        if (pond[currRow, currCol] == 'F')
                        {
                            pond[currRow, currCol] = '-';

                            if (currCol == size - 1)
                            {
                                for (int col = currCol; col >= 0; col--)
                                {
                                    currCol = col;
                                }

                                if (Char.IsLower(pond[currRow, currCol]))
                                {
                                    branches.Push(pond[currRow, currCol]);
                                }
                            }
                            else if (currCol < size - 1)
                            {
                                for (int col = currCol; col < size; col++)
                                {
                                    currCol = col;
                                }

                                if (Char.IsLower(pond[currRow, currCol]))
                                {
                                    branches.Push(pond[currRow, currCol]);
                                }
                            }
                            pond[currRow, currCol] = 'B';
                        }
                        else if (char.IsLower(pond[currRow, currCol]))
                        {
                            branches.Push(pond[currRow, currCol]);
                            pond[currRow, currCol] = 'B';
                        }
                        else
                        {
                            pond[currRow, currCol] = 'B';
                        }
                    }
                    else
                    {
                        if (branches.Count > 0)
                        {
                            branches.Pop();
                        }
                    }
                }
                countBranches = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (Char.IsLower(pond[row, col]))
                        {
                            countBranches++;
                        }
                    }
                }

                if (countBranches == 0)
                {
                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
                    PrintMatrix(pond, size);
                    return;
                }
            }
            Console.WriteLine($"The Beaver failed to collect every wood branch. There are {countBranches} branches left.");
            PrintMatrix(pond, size);
        }

        static void PrintMatrix(char[,] pond, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(pond[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

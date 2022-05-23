using System;
using System.Linq;

namespace JaggedArrayModificaion
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            int[][] jaggedArr = new int[rowsCount][];

            for (int row = 0; row < jaggedArr.Length; row++)
            {
                jaggedArr[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(" ");

                string cmdType = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                if (row < 0 || row >= jaggedArr.Length || col < 0 || col >= jaggedArr[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (cmdType == "Add")
                {
                    jaggedArr[row][col] += value;
                }
                else if (cmdType == "Subtract")
                {
                    jaggedArr[row][col] -= value;
                }
            }

            foreach (int[] row in jaggedArr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}

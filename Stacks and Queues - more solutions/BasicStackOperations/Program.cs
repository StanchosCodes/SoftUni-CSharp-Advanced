using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cmdArgs = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int quantityToPush = cmdArgs[0];
            int quantityToPop = cmdArgs[1];
            int numToFind = cmdArgs[2];

            int[] numbersToPush = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>(numbersToPush);

            for (int i = 0; i < quantityToPop; i++)
            {
                numbers.Pop();
            }

            if (numbers.Count > 0)
            {
                if (numbers.Contains(numToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine($"{numbers.Min()}");
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}

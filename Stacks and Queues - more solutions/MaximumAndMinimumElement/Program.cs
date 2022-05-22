using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfQueries = int.Parse(Console.ReadLine());

            Stack<int> sequence = new Stack<int>();

            for (int i = 0; i < numberOfQueries; i++)
            {
                int[] command = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                if (command[0] == 1)
                {
                    int numToPush = command[1];
                    sequence.Push(numToPush);
                }
                else if (command[0] == 2)
                {
                    if (sequence.Count > 0)
                    {
                        sequence.Pop();
                    }
                }
                else if (command[0] == 3)
                {
                    if (sequence.Count > 0)
                    {
                        Console.WriteLine(sequence.Max());
                    }
                }
                else if (command[0] == 4)
                {
                    if (sequence.Count > 0)
                    {
                        Console.WriteLine(sequence.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}

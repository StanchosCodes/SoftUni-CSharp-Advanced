using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArgs = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int quantityToDequeue = numArgs[1];
            int numToFind = numArgs[2];

            int[] numbersToEnqueue = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(numbersToEnqueue);

            for (int i = 0; i < quantityToDequeue; i++)
            {
                numbers.Dequeue();
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

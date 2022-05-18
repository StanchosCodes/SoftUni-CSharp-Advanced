using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(nums);
            Queue<int> evenNums = new Queue<int>();

            while (numbers.Count > 0)
            {
                if (numbers.Peek() % 2 != 0)
                {
                    numbers.Dequeue();
                }
                else
                {
                    evenNums.Enqueue(numbers.Dequeue());
                }
            }

            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}

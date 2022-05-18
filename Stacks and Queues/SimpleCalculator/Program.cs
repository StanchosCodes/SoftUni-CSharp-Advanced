using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] task = Console.ReadLine().Split(' ');

            Stack<string> numsAndOperations = new Stack<string>();

            Array.Reverse(task);

            foreach (var item in task)
            {
                numsAndOperations.Push(item);
            }

            int sum = int.Parse(numsAndOperations.Pop());
            List<string> currStep = new List<string>();

            while (numsAndOperations.Count > 0)
            {
                currStep.Add(numsAndOperations.Pop());
                currStep.Add(numsAndOperations.Pop());

                if (currStep[0] == "+")
                {
                    sum += int.Parse(currStep[1]);
                }
                else
                {
                    sum -= int.Parse(currStep[1]);
                }

                currStep.Clear();
            }

            Console.WriteLine(sum);
        }
    }
}

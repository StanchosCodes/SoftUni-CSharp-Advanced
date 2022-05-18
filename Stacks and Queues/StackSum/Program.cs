using System;
using System.Linq;
using System.Collections.Generic;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>(nums);

            string cmd;
            while ((cmd = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdItems = cmd.Split(' ');

                if (cmdItems[0] == "add")
                {
                    numbers.Push(int.Parse(cmdItems[1]));
                    numbers.Push(int.Parse(cmdItems[2]));
                }
                else if (cmdItems[0] == "remove")
                {
                    int countToRemove = int.Parse(cmdItems[1]);
                    if (numbers.Count >= countToRemove)
                    {
                        for (int i = 0; i < countToRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }

            int sum = numbers.ToArray().Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

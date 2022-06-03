using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<List<int>, List<int>> Adding = list => list.Select(num => num += 1).ToList();
            Func<List<int>, List<int>> Multiplying = list => list.Select(num => num *= 2).ToList();
            Func<List<int>, List<int>> Subtracting = list => list.Select(num => num -= 1).ToList();
            Action<List<int>> Printing = list => Console.WriteLine(string.Join(" ", list));

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    numbers = Adding(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = Multiplying(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = Subtracting(numbers);
                }
                else if (command == "print")
                {
                    Printing(numbers);
                }
            }
        }
    }
}

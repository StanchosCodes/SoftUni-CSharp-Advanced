using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            List<int> deviders = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> divisibleNums = new List<int>();

            for (int i = 1; i <= endOfRange; i++)
            {
                bool IsDivisibleNumber = true;

                Predicate<int> IsDivisible = num => i % num == 0;

                foreach (int devider in deviders)
                {
                    if (!IsDivisible(devider))
                    {
                        IsDivisibleNumber = false;
                        break;
                    }
                }

                if (IsDivisibleNumber)
                {
                    divisibleNums.Add(i);
                }

            }

            Console.WriteLine(string.Join(" ", divisibleNums));

        }
    }
}

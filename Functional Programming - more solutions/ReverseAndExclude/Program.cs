using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();

            int divider = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = num => num % divider == 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (isDivisible(nums[i]))
                {
                    nums.Remove(nums[i]);
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

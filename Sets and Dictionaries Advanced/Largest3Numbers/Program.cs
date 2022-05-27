using System;
using System.Linq;
using System.Collections.Generic;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(n => n).ToList();
            // List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(n => n).ToList().Take(3);
            // Взима 3 числа, или колкото има ако са по - малко

            for (int i = 0; i < 3; i++)
            {
                if (i < nums.Count)
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }
    }
}

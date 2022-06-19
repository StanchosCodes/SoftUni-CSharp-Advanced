using System;
using System.Linq;

namespace CustomComparatorAlternative
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortEvenOdd sortMethod = new SortEvenOdd();

            Array.Sort(nums, sortMethod);

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

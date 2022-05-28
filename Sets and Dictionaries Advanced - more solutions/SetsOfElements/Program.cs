using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            int n = nums[0];
            int m = nums[1];

            for (int i = 0; i < n; i++)
            {
                int nums1 = int.Parse(Console.ReadLine());

                set1.Add(nums1);
            }

            for (int i = 0; i < m; i++)
            {
                int nums2 = int.Parse(Console.ReadLine());

                set2.Add(nums2);
            }

            set1.IntersectWith(set2); // This will leave in the first set only the elements which are also in the second set

            Console.WriteLine(string.Join(" ", set1));
        }
    }
}

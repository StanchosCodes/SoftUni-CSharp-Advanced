using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static int ParseVariant1(string str) // Variant 1 to parse to int with Method
        {
            int result = int.Parse(str);
            return result;
        }

        static int ParseVariant2(string str) => int.Parse(str); // variant 2 to parse to int
        static void Main(string[] args)
        {
            Func<string, int> ParseVariant3 = (string str) => int.Parse(str); // Variant 3 to parse to int with Delegate

            string input = Console.ReadLine();

            int[] nums = input.Split(", ").Select(ParseVariant2).ToArray();
            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum());
        }
    }
}

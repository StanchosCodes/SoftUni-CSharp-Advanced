using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parseStringToInt = x => int.Parse(x); // Function to parse to int

            Func<int, bool> isEven = x => x % 2 == 0; // Function to check if the given number is even

            Func<int, int> order = x => x; // Function to order a sequence

            string input = Console.ReadLine(); // Reading a string from the console
            string[] inputArgs = input.Split(", "); // Making an array of strings from the input string 
            int[] nums = inputArgs.Select(parseStringToInt).ToArray(); // Parsing the string array to int array
            int[] evenNums = nums.Where(isEven).ToArray(); // Making an even array from the nums array
            int[] orderedEvenNums = evenNums.OrderBy(order).ToArray(); // Ordering the even array in increasing order

            Console.WriteLine(string.Join(", ", orderedEvenNums)); // Printing the ordered array of even nums
        }
    }
}

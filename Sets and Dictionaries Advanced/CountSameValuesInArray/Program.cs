using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            Dictionary<double, int> occurancies = new Dictionary<double, int>();

            foreach (double num in numbers)
            {
                if (occurancies.ContainsKey(num))
                {
                    occurancies[num]++;
                }
                else
                {
                    occurancies[num] = 1;
                }
            }

            foreach (var num in occurancies)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}

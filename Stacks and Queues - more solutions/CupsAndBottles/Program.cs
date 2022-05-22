using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsArr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] bottlesArr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Stack<int> cups = new Stack<int>(cupsArr.Reverse());
            Stack<int> bottles = new Stack<int>(bottlesArr);

            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currBottle = bottles.Pop();

                if (currBottle >= cups.Peek())
                {
                    wastedWater += currBottle - cups.Peek();
                    cups.Pop();
                }
                else
                {
                    int currCup = cups.Pop();
                    cups.Push(currCup - currBottle);
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}

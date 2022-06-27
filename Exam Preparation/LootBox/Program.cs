using System;
using System.Collections.Generic;
using System.Linq;

namespace LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBoxArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondBoxArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> firstBox = new Queue<int>(firstBoxArr);
            Stack<int> secondBox = new Stack<int>(secondBoxArr);

            List<int> claimedItems = new List<int>();

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                int currFirstValue = firstBox.Peek();
                int currSecondValue = secondBox.Peek();

                int currClaimedItem = currFirstValue + currSecondValue;

                if (currClaimedItem % 2 == 0)
                {
                    claimedItems.Add(currClaimedItem);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }

            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondBox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            int sum = claimedItems.Sum();

            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}

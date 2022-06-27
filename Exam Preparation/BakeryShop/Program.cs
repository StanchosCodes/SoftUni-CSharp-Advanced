using System;
using System.Collections.Generic;
using System.Linq;

namespace BakeryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] waterArr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] flourArr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Queue<double> waterQueue = new Queue<double>();
            Stack<double> flourStack = new Stack<double>();

            for (int i = 0; i < waterArr.Length; i++)
            {
                waterQueue.Enqueue(waterArr[i]);
            }
            for (int i = 0; i < flourArr.Length; i++)
            {
                flourStack.Push(flourArr[i]);
            }

            Dictionary<string, int> bakedThings = new Dictionary<string, int>();
            bakedThings.Add("Croissant", 0);
            bakedThings.Add("Muffin", 0);
            bakedThings.Add("Baguette", 0);
            bakedThings.Add("Bagel", 0);

            while (waterQueue.Count > 0 && flourStack.Count > 0)
            {
                double currWater = waterQueue.Peek();
                double currFlour = flourStack.Peek();

                double ingradientsAmount = currWater + currFlour;

                double waterPercentage = (currWater * 100) / ingradientsAmount;
                double flourPercentage = 100 - waterPercentage;

                if (waterPercentage == 50 && flourPercentage == 50)
                {
                    bakedThings["Croissant"]++;
                }
                else if (waterPercentage == 40 && flourPercentage == 60)
                {
                    bakedThings["Muffin"]++;
                }
                else if (waterPercentage == 30 && flourPercentage == 70)
                {
                    bakedThings["Baguette"]++;
                }
                else if (waterPercentage == 20 && flourPercentage == 80)
                {
                    bakedThings["Bagel"]++;
                }
                else
                {
                    double neededFlour = currWater;
                    waterQueue.Dequeue();
                    flourStack.Pop();
                    flourStack.Push(currFlour - neededFlour);
                    bakedThings["Croissant"]++;
                    continue;
                }
                waterQueue.Dequeue();
                flourStack.Pop();
            }

            foreach (var item in bakedThings.OrderByDescending(baked => baked.Value).ThenBy(baked => baked.Key))
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

            if (waterQueue.Count > 0)
            {
                Console.WriteLine($"Water left: {string.Join(", ", waterQueue.OrderBy(w => w))}");
            }
            else
            {
                Console.WriteLine("Water left: None");
            }

            if (flourStack.Count > 0)
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flourStack.OrderBy(f => f))}");
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }
        }
    }
}

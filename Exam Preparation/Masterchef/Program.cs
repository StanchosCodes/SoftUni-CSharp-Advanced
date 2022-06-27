using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ingradientsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] freshnessArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> ingradients = new Queue<int>(ingradientsArr);
            Stack<int> freshnessLevel = new Stack<int>(freshnessArr);

            const int DippingSauce = 150;
            const int GreenSalad = 250;
            const int ChocolateCake = 300;
            const int Lobster = 400;

            SortedDictionary<string, int> dishes = new SortedDictionary<string, int>()
            {
                { "Dipping sauce", 0 },
                { "Green salad", 0 },
                { "Chocolate cake", 0 },
                { "Lobster", 0 },
            };

            while (ingradients.Count > 0 && freshnessLevel.Count > 0)
            {
                int currIngradient = ingradients.Peek();
                int currFreshnessLevel = freshnessLevel.Peek();

                if (currIngradient == 0)
                {
                    ingradients.Dequeue();
                    continue;
                }

                if (currIngradient * currFreshnessLevel == DippingSauce)
                {
                    dishes["Dipping sauce"]++;
                }
                else if (currIngradient * currFreshnessLevel == GreenSalad)
                {
                    dishes["Green salad"]++;
                }
                else if (currIngradient * currFreshnessLevel == ChocolateCake)
                {
                    dishes["Chocolate cake"]++;
                }
                else if (currIngradient * currFreshnessLevel == Lobster)
                {
                    dishes["Lobster"]++;
                }
                else
                {
                    freshnessLevel.Pop();
                    ingradients.Dequeue();
                    ingradients.Enqueue(currIngradient + 5);
                    continue;
                }

                freshnessLevel.Pop();
                ingradients.Dequeue();
            }

            if (dishes.Any(dish => dish.Value == 0))
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }
            else
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }

            if (ingradients.Count > 0)
            {
                int sum = ingradients.Sum();
                Console.WriteLine($"Ingredients left: {sum}");
            }

            foreach (var dish in dishes.Where(dish => dish.Value > 0))
            {
                Console.WriteLine($" # {dish.Key} --> {dish.Value}");
            }
        }
    }
}

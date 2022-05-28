using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> colorsClothesCount = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] colorAndClothes = Console.ReadLine().Split(" -> ");
                string[] clothes = colorAndClothes[1].Split(',');

                string currColor = colorAndClothes[0];

                if (!colorsClothesCount.ContainsKey(currColor))
                {
                    colorsClothesCount.Add(currColor, new Dictionary<string, int>());
                }

                Dictionary<string, int> dresses = colorsClothesCount[currColor];

                foreach (var dress in clothes)
                {
                    if (!dresses.ContainsKey(dress))
                    {
                        dresses.Add(dress, 1);
                    }
                    else
                    {
                        dresses[dress]++;
                    }
                }
            }

            string[] searchedCloth = Console.ReadLine().Split(" ");

            string searchedColor = searchedCloth[0];
            string searchedDress = searchedCloth[1];

            foreach (var color in colorsClothesCount)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloth in colorsClothesCount[color.Key])
                {
                    if (searchedColor == color.Key && searchedDress == cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace TilesMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] whiteTilesArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] greyTilesArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> greyTiles = new Queue<int>(greyTilesArr);
            Stack<int> whiteTiles = new Stack<int>(whiteTilesArr);

            const int SinkValue = 40;
            const int OvenValue = 50;
            const int CountertopValue = 60;
            const int WallValue = 70;

            Dictionary<string, int> madeTiles = new Dictionary<string, int>()
            {
                { "Sink", 0 },
                { "Oven", 0 },
                { "Countertop", 0 },
                { "Wall", 0 },
                { "Floor", 0 }
            };

            while (greyTiles.Count > 0 && whiteTiles.Count > 0)
            {
                int currGreyTile = greyTiles.Peek();
                int currWhiteTile = whiteTiles.Peek();

                if (currGreyTile != currWhiteTile)
                {
                    whiteTiles.Push(whiteTiles.Pop() / 2);
                    greyTiles.Enqueue(greyTiles.Dequeue());
                }
                else
                {
                    int sum = currGreyTile + currWhiteTile;

                    if (sum == SinkValue)
                    {
                        madeTiles["Sink"]++;
                    }
                    else if (sum == OvenValue)
                    {
                        madeTiles["Oven"]++;
                    }
                    else if (sum == CountertopValue)
                    {
                        madeTiles["Countertop"]++;
                    }
                    else if (sum == WallValue)
                    {
                        madeTiles["Wall"]++;
                    }
                    else
                    {
                        madeTiles["Floor"]++;
                    }

                    greyTiles.Dequeue();
                    whiteTiles.Pop();
                }
            }

            if (whiteTiles.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
            }

            if (greyTiles.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }

            foreach (var tile in madeTiles.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            {
                if (tile.Value > 0)
                {
                    Console.WriteLine($"{tile.Key}: {tile.Value}");
                }
            }
        }
    }
}

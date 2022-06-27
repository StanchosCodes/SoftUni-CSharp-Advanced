using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] steelArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] carbonArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> steel = new Queue<int>(steelArr);
            Stack<int> carbon = new Stack<int>(carbonArr);

            const int GladiusValue = 70;
            const int ShamshirValue = 80;
            const int KatanaValue = 90;
            const int SabreValue = 110;
            const int BroadswordValue = 150;

            SortedDictionary<string, int> forgedWeapons = new SortedDictionary<string, int>()
            {
                { "Gladius", 0 },
                { "Shamshir", 0 },
                { "Katana", 0 },
                { "Sabre", 0 },
                { "Broadsword", 0 },
            };

            int forgedCount = 0;

            while (steel.Count > 0 && carbon.Count > 0)
            {
                int currSteel = steel.Peek();
                int currCarbon = carbon.Peek();

                int sum = currSteel + currCarbon;

                steel.Dequeue();

                if (sum == 70)
                {
                    forgedWeapons["Gladius"]++;
                    forgedCount++;
                }
                else if (sum == 80)
                {
                    forgedWeapons["Shamshir"]++;
                    forgedCount++;
                }
                else if (sum == 90)
                {
                    forgedWeapons["Katana"]++;
                    forgedCount++;
                }
                else if (sum == 110)
                {
                    forgedWeapons["Sabre"]++;
                    forgedCount++;
                }
                else if (sum == 150)
                {
                    forgedWeapons["Broadsword"]++;
                    forgedCount++;
                }
                else
                {
                    carbon.Pop();
                    carbon.Push(currCarbon + 5);
                    continue;
                }

                carbon.Pop();
            }

            if (forgedCount > 0)
            {
                Console.WriteLine($"You have forged {forgedCount} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (steel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            }

            if (carbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }

            if (forgedCount > 0)
            {
                foreach (var weapon in forgedWeapons)
                {
                    if (weapon.Value > 0)
                    {
                        Console.WriteLine($"{weapon.Key}: {weapon.Value}");
                    }
                }
            }
        }
    }
}

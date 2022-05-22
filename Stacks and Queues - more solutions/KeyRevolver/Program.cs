using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            double bulletPrice = double.Parse(Console.ReadLine());
            int sizeOfTheGunBarrel = int.Parse(Console.ReadLine());
            int[] bulletsArr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int[] locksArr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int priceOfTheIntelligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsArr);
            Queue<int> locks = new Queue<int>(locksArr);

            int bulletsCounter = 0;
            int startBullets = bullets.Count;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                int currBullet = bullets.Pop();
                bulletsCounter++;

                int currLock = locks.Peek();

                if (currBullet <= currLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (bullets.Count == 0)
                {
                    break;
                }
                if (bulletsCounter == sizeOfTheGunBarrel)
                {
                    Console.WriteLine("Reloading!");
                    bulletsCounter = 0;
                }
            }
            if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int bulletsLeft = bullets.Count;
                double totalPriceForTheBullets = bulletPrice * (startBullets - bulletsLeft);
                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${priceOfTheIntelligence - totalPriceForTheBullets}");
            }
        }
    }
}

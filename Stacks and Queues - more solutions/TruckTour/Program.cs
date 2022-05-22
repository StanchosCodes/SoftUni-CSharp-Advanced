using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int stops = int.Parse(Console.ReadLine());

            Queue<int[]> truckTrip = new Queue<int[]>();

            for (int i = 0; i < stops; i++)
            {
                int[] fuelAndDistance = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                int fuelToTake = fuelAndDistance[0];
                int distanceToTheNextStop = fuelAndDistance[1];

                truckTrip.Enqueue(fuelAndDistance);
            }

            int startIndex = 0;

            while (true)
            {
                int currPetrol = 0;

                foreach (var info in truckTrip)
                {
                    int currPetrolToTake = info[0];
                    int currDistanceToPass = info[1];

                    currPetrol += currPetrolToTake;
                    currPetrol -= currDistanceToPass;

                    if (currPetrol < 0)
                    {
                        int[] currStop = truckTrip.Dequeue();
                        truckTrip.Enqueue(currStop);
                        startIndex++;
                        break;
                    }
                }

                if (currPetrol >= 0)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}

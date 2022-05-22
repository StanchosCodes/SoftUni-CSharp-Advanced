using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boxNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> clothesNums = new Stack<int>(boxNums);

            int racks = 1;
            int currRackCapacity = 0;

            while (clothesNums.Count > 0)
            {
                int currClothNum = clothesNums.Peek();

                if (currRackCapacity == rackCapacity)
                {
                    racks++;
                    currRackCapacity = 0;
                    currRackCapacity += currClothNum;
                    clothesNums.Pop();
                }
                else if (currRackCapacity + currClothNum > rackCapacity)
                {
                    racks++;
                    currRackCapacity = 0;
                    currRackCapacity += currClothNum;
                    clothesNums.Pop();
                }
                else
                {
                    currRackCapacity += currClothNum;
                    clothesNums.Pop();
                }
            }

            Console.WriteLine(racks);
        }
    }
}

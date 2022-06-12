using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            List<int> elements = new List<int>();

            for (int i = 0; i < range; i++)
            {
                int input = int.Parse(Console.ReadLine());
                elements.Add(input);
            }

            Box<int> newBox = new Box<int>(elements);

            int[] swapCommand = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstIndex = swapCommand[0];
            int secondIndex = swapCommand[1];

            newBox.Swap(elements, firstIndex, secondIndex);

            Console.WriteLine(newBox);
        }
    }
}

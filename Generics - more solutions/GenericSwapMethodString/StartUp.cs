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

            List<string> elements = new List<string>();

            for (int i = 0; i < range; i++)
            {
                string input = Console.ReadLine();
                elements.Add(input);
            }

            Box<string> newBox = new Box<string>(elements);

            int[] swapCommand = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstIndex = swapCommand[0];
            int secondIndex = swapCommand[1];

            newBox.Swap(elements, firstIndex, secondIndex);

            Console.WriteLine(newBox);
        }
    }
}

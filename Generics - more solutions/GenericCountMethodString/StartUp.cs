using System;
using System.Collections.Generic;

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

            string elementsForComparison = Console.ReadLine();

            Console.WriteLine(newBox.CountOfGreaterElements(elements, elementsForComparison));
        }
    }
}

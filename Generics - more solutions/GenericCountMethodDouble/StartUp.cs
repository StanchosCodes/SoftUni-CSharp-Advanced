using System;
using System.Collections.Generic;

namespace GenericBoxOfString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            List<double> elements = new List<double>();

            for (int i = 0; i < range; i++)
            {
                double input = double.Parse(Console.ReadLine());
                elements.Add(input);
            }
                Box<double> newBox = new Box<double>(elements);

            double elementsForComparison = double.Parse(Console.ReadLine());

            Console.WriteLine(newBox.CountOfGreaterElements(elements, elementsForComparison));
        }
    }
}

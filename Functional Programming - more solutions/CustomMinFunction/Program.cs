﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<List<int>, int> MinElement = num => num.Min();

            Console.WriteLine(MinElement(numbers));
        }
    }
}

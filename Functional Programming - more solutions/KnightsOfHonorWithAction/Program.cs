using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            Action<string> NameWithTitle = name => Console.WriteLine("Sir " + name);

            foreach (string name in names)
            {
                NameWithTitle(name);
            }
        }
    }
}

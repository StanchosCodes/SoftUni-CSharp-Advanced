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

            Func<string, string> NameWithTitle = name => "Sir " + name;

            foreach (string name in names)
            {
                Console.WriteLine(NameWithTitle(name));
            }
        }
    }
}

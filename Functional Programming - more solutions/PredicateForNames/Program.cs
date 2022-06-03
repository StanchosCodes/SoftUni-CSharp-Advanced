using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Predicate<string> IsEqualToLength = name => name.Length <= nameLength;

            for (int i = 0; i < names.Count; i++)
            {
                if (!IsEqualToLength(names[i]))
                {
                    names.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join("\n", names));
        }
    }
}

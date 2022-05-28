using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            SortedSet<string> uniqueCompounds = new SortedSet<string>();

            for (int i = 0; i < num; i++)
            {
                string[] compounds = Console.ReadLine().Split(' ');

                for (int j = 0; j < compounds.Length; j++)
                {
                    uniqueCompounds.Add(compounds[j]);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueCompounds));
        }
    }
}

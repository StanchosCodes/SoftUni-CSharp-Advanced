using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> occurancies = new SortedDictionary<char, int>();

            foreach (char ch in input)
            {
                if (!occurancies.ContainsKey(ch))
                {
                    occurancies.Add(ch, 1);
                }
                else
                {
                    occurancies[ch]++;
                }
            }

            foreach (var charecter in occurancies)
            {
                Console.WriteLine($"{charecter.Key}: {charecter.Value} time/s");
            }
        }
    }
}

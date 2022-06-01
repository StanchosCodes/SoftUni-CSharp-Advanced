using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> IsUpperFirstLetter = (string x) => x.Length > 0 && char.IsUpper(x[0]);

            Console.WriteLine(string.Join("\n", 
                Console.ReadLine()
                .Split(' ')
                .Where(x => IsUpperFirstLetter(x))
                .ToList()));
        }
    }
}

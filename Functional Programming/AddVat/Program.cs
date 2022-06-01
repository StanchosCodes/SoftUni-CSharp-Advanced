using System;
using System.Linq;

namespace AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            static double ParseToDouble(string theString) => double.Parse(theString);

            Func<double, double> addingVat = n => n *= 1.2;


            string input = Console.ReadLine();

            double[] numsArray = input
                .Split(", ")
                .Select(ParseToDouble)
                .ToArray();

            double[] numsWithVat = numsArray.Select(addingVat)
                .ToArray();

            Array.ForEach(numsWithVat, num => Console.WriteLine($"{num:f2}")); // Same as foreach cicle
        }
    }
}

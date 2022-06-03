using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boundaries = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string evenOrOddList = Console.ReadLine();

            List<int> numsList = new List<int>();

            Predicate<int> IsEvenOdd = num => num % 2 == 0;


            for (int i = boundaries[0]; i <= boundaries[1]; i++)
            {
                if (evenOrOddList == "even")
                {
                    if (IsEvenOdd(i))
                    {
                        numsList.Add(i);
                    }
                }
                else
                {
                    if (!IsEvenOdd(i))
                    {
                        numsList.Add(i);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numsList));
        }
    }
}

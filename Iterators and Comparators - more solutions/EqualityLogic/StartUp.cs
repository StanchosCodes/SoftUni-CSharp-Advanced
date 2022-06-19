using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<Person> hashSet = new HashSet<Person>();
            SortedSet<Person> sortedSet = new SortedSet<Person>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();

                string currName = input[0];
                int currAge = int.Parse(input[1]);

                hashSet.Add(new Person(currName, currAge));
                sortedSet.Add(new Person(currName, currAge));
            }

            Console.WriteLine(hashSet.Count);
            Console.WriteLine(sortedSet.Count);
        }
    }
}

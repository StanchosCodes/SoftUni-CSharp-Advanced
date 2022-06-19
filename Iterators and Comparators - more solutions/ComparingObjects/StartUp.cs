using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split();

                string currName = cmdArgs[0];
                int currAge = int.Parse(cmdArgs[1]);
                string currTown = cmdArgs[2];

                people.Add(new Person(currName, currAge, currTown));
            }

            int indexOfPersonToCompare = int.Parse(Console.ReadLine()) -1;
            int equalPersons = 0;
            int notEqualPersons = 0;

            foreach (Person person in people)
            {
                if (people[indexOfPersonToCompare].CompareTo(person) == 0)
                {
                    equalPersons++;
                }
                else
                {
                    notEqualPersons++;
                }
            }

            if (equalPersons <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPersons} {notEqualPersons} {people.Count}");
            }
        }
    }
}

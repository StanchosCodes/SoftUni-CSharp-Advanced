using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            string command;
            while ((command = Console.ReadLine()) != "Party!")
            {
                Predicate<string> CurrentPredicate = GetPredicate(command);
                if (command.StartsWith("Double"))
                {
                    for (int i = 0; i < people.Count; i++)
                    {
                        if (CurrentPredicate(people[i]))
                        {
                            people.Insert(i + 1, people[i]);
                            i++;
                        }
                    }
                }
                else if (command.StartsWith("Remove"))
                {
                    people.RemoveAll(CurrentPredicate);
                }
            }

            if (people.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Predicate<string> GetPredicate(string command)
        {
            string cmdArg = command.Split()[1];
            string arg2 = command.Split()[2];

            Predicate<string> CurrPredicate = null;

            if (cmdArg == "StartsWith")
            {
                CurrPredicate = name => name.StartsWith(arg2);
            }
            else if (cmdArg == "EndsWith")
            {
                CurrPredicate = name => name.EndsWith(arg2);
            }
            else if (cmdArg == "Length")
            {
                int lengthValue = int.Parse(arg2);

                CurrPredicate = name => name.Length == lengthValue;
            }

            return CurrPredicate;
        }
    }
}

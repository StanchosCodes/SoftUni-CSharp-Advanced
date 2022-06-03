using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();
            List<string> modifiedList = new List<string>();

            modifiedList.AddRange(people);

            string command;
            while ((command = Console.ReadLine()) != "Print")
            {
                Predicate<string> CurrentPredicate = GetPredicate(command);
                if (command.StartsWith("Add"))
                {
                    modifiedList.RemoveAll(CurrentPredicate);
                }
                else if (command.StartsWith("Remove"))
                {
                    foreach (string name in people)
                    {
                        if (CurrentPredicate(name))
                        {
                            modifiedList.Add(name);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", modifiedList));
        }

        static Predicate<string> GetPredicate(string command)
        {
            string cmdArg = command.Split(';')[1];
            string arg2 = command.Split(';')[2];

            Predicate<string> CurrPredicate = null;

            if (cmdArg == "Starts with")
            {
                CurrPredicate = name => name.StartsWith(arg2);
            }
            else if (cmdArg == "Ends with")
            {
                CurrPredicate = name => name.EndsWith(arg2);
            }
            else if (cmdArg == "Length")
            {
                int lengthValue = int.Parse(arg2);

                CurrPredicate = name => name.Length == lengthValue;
            }
            else if (cmdArg == "Contains")
            {
                CurrPredicate = name => name.Contains(arg2);
            }

            return CurrPredicate;
        }
    }
}
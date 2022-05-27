using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regularList = new HashSet<string>();
            HashSet<string> vipList = new HashSet<string>();

            string cmd = string.Empty;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "PARTY")
                {
                    while ((cmd = Console.ReadLine()) != "END")
                    {
                        vipList.Remove(cmd);
                        regularList.Remove(cmd);
                    }
                }
                
                if (input == "END" || cmd == "END")
                {
                    int leftOverGuestsCount = vipList.Count + regularList.Count;

                    Console.WriteLine(leftOverGuestsCount);
                    if (vipList.Count > 0)
                    {
                        foreach (string vipReservation in vipList)
                        {
                            Console.WriteLine(vipReservation);
                        }
                    }
                    if (regularList.Count > 0)
                    {
                        foreach (string regularReservation in regularList)
                        {
                            Console.WriteLine(regularReservation);
                        }
                    }

                    break;
                }

                if (char.IsDigit(input[0]))
                {
                    vipList.Add(input);
                }
                else
                {
                    regularList.Add(input);
                }
            }
        }
    }
}

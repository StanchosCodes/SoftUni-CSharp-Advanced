using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> plateNumbers = new HashSet<string>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(", ");

                string direction = cmdArgs[0];
                string plate = cmdArgs[1];

                if (direction == "IN")
                {
                    plateNumbers.Add(plate);
                }
                else
                {
                    plateNumbers.Remove(plate);
                }
            }

            if (plateNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string number in plateNumbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}

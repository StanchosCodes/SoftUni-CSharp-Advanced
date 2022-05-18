using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToPass = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int passedCars = 0;
            Queue<string> cars = new Queue<string>();

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < numberToPass; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}

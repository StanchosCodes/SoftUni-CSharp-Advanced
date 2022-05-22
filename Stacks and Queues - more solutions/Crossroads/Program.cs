using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            int carsPassed = 0;

            Queue<char[]> carsToChars = new Queue<char[]>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command != "green")
                {
                    char[] currCar = command.ToCharArray();
                    carsToChars.Enqueue(currCar);
                }
                else
                {
                    bool isQueueEmpty = false;

                    if (carsToChars.Count == 0)
                    {
                        isQueueEmpty = true;
                        continue;
                    }
                    int timeLeft = greenLight;
                    int currCarLength = carsToChars.Peek().Length;

                    while (timeLeft > 0)
                    {
                        if (currCarLength < timeLeft)
                        {
                            timeLeft -= currCarLength;
                            carsToChars.Dequeue();
                            carsPassed++;

                            if (carsToChars.Count == 0)
                            {
                                isQueueEmpty = true;
                                break;
                            }
                        }
                        else
                        {
                            currCarLength -= timeLeft;
                            break;
                        }

                        currCarLength = carsToChars.Peek().Length;
                    }
                    if (isQueueEmpty)
                    {
                        continue;
                    }
                    if (currCarLength <= freeWindow)
                    {
                        carsToChars.Dequeue();
                        carsPassed++;
                    }
                    else
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{string.Join("", carsToChars.Peek())} was hit at {carsToChars.Peek()[carsToChars.Peek().Length - (currCarLength - freeWindow)]}.");
                        Environment.Exit(0);
                    }
                }
            }

            if (command == "END")
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
            }
        }
    }
}

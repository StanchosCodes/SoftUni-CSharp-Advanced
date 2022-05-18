using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');

            Queue<string> children = new Queue<string>(names);

            int passes = int.Parse(Console.ReadLine());

            while (children.Count > 1)
            {
                for (int i = 1; i <= passes; i++)
                {
                    if (i == passes)
                    {
                        Console.WriteLine($"Removed {children.Dequeue()}");
                        break;
                    }

                    children.Enqueue(children.Dequeue());
                }
            }

            Console.WriteLine($"Last is {children.Peek()}");
        }
    }
}

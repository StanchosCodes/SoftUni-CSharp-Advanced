using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAmount = int.Parse(Console.ReadLine());

            int[] ordersArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(ordersArr);

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (foodAmount >= orders.Peek())
                {
                    int currOrder = orders.Dequeue();
                    foodAmount -= currOrder;
                }
                else
                {
                    break;
                }
            }

            if (orders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}

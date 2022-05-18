using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> inputString = new Stack<char>();

            foreach (char ch in input)
            {
                inputString.Push(ch);
            }

            while (inputString.Count > 0)
            {
                Console.Write(inputString.Pop());
            }
        }
    }
}

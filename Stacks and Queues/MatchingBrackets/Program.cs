using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> indices = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                char currentChar = expression[i];

                if (currentChar == '(')
                {
                    indices.Push(i);
                }
                else if (currentChar == ')')
                {
                    int startIndex = indices.Pop();
                    int endIndex = i;

                    string subExpression = expression.Substring(startIndex, endIndex - startIndex + 1);

                    Console.WriteLine(subExpression);
                }    
            }
        }
    }
}

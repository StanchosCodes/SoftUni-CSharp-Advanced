using System;
using System.Collections.Generic;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string paranthesis = Console.ReadLine();

            Stack<char> paranthesisSequence = new Stack<char>();

            bool isBalanced = true;

            for (int i = 0; i < paranthesis.Length; i++)
            {
                char currChar = paranthesis[i];

                if (currChar == '(' || currChar == '{' || currChar == '[')
                {
                    paranthesisSequence.Push(currChar);
                }
                else
                {
                    if (paranthesisSequence.Count > 0)
                    {
                        if (paranthesisSequence.Peek() + 2 == currChar || paranthesisSequence.Peek() + 1 == currChar)
                        {
                            paranthesisSequence.Pop();
                        }
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced && paranthesisSequence.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

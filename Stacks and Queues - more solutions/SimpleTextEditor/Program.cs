using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfOperations = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();
            Stack<string> textConditions = new Stack<string>();

            for (int i = 0; i < numOfOperations; i++)
            {
                string command = Console.ReadLine();

                if (command.StartsWith("1"))
                {
                    textConditions.Push(text.ToString());
                    string textToAppend = command.Split()[1];
                    text.Append(textToAppend);
                }
                else if (command.StartsWith("2"))
                {
                    textConditions.Push(text.ToString());
                    int count = int.Parse(command.Split()[1]);
                    text.Remove(text.Length - count, count);
                }
                else if (command.StartsWith("3"))
                {
                    int indexToPrint = int.Parse(command.Split()[1]);
                    Console.WriteLine(text[indexToPrint - 1]);
                }
                else if (command.StartsWith("4"))
                {
                    text = new StringBuilder(textConditions.Pop());
                }
            }
        }
    }
}

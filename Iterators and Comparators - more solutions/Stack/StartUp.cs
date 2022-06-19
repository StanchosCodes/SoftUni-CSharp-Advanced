using System;
using System.Linq;

namespace Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> newStack = new Stack<string>(); 
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "Push")
                {
                    newStack.Push(cmdArgs.Skip(1).Select(e => e.Split(',').First()).ToArray());
                }
                else if (cmdArgs[0] == "Pop")
                {
                    try
                    {
                        newStack.Pop();
                    }
                    catch (ArgumentException argumentExceptionMessage)
                    {
                        Console.WriteLine(argumentExceptionMessage.Message);
                    }
                }
            }

            foreach (string element in newStack)
            {
                Console.WriteLine(element);
            }
            foreach (string element in newStack)
            {
                Console.WriteLine(element);
            }
        }
    }
}

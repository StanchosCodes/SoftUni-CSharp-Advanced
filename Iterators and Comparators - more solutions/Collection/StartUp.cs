using System;
using System.Linq;

namespace ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> list = null;

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs[0] == "Create")
                {
                    list = new ListyIterator<string>(cmdArgs.Skip(1).ToArray());
                }
                else if (cmdArgs[0] == "Move")
                {
                    Console.WriteLine(list.Move());
                }
                else if (cmdArgs[0] == "Print")
                {
                    list.Print();
                }
                else if (cmdArgs[0] == "HasNext")
                {
                    Console.WriteLine(list.HasNext());
                }
                else if (cmdArgs[0] == "PrintAll")
                {
                    list.PrintAll();
                }
            }
        }
    }
}

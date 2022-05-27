using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string inputName = Console.ReadLine();

                names.Add(inputName);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

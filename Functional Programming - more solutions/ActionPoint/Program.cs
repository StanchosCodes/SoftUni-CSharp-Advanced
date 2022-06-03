using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> PrintLines = line => Console.WriteLine(line);

            List<string> inputText = Console.ReadLine().Split(' ').ToList();

            inputText.ForEach(PrintLines);
        }
    }
}

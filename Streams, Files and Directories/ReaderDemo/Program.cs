using System;
using System.IO;

namespace ReaderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../input.txt");
            int lineCount = 0;
            while (true)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    // The end of the stream (no more lines in the text file) has been reached so we should break the reading
                    break;
                }
                lineCount++;
                Console.WriteLine($"{lineCount}. {line}");
            }
        }
    }
}

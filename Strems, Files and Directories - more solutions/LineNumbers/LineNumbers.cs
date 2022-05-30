using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\Files\text.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);

            int count = 0;
            List<string> outputLines = new List<string>();

            foreach (string line in lines)
            {
                count++;

                int countLetters = line.Count(char.IsLetter);
                int countSymbols = line.Count(char.IsPunctuation);
                string modifiedLine = $"Line {count}: {line} ({countLetters})({countSymbols})";

                outputLines.Add(modifiedLine);
            }

            File.WriteAllLines(outputFilePath, outputLines);
        }
    }
}

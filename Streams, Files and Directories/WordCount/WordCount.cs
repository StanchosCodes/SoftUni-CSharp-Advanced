namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            StreamReader textReader = new StreamReader(textFilePath);
            StreamReader wordsReader = new StreamReader(wordsFilePath);
            StreamWriter outputWriter = new StreamWriter(outputFilePath);
            string[] words = wordsReader.ReadToEnd().Split(" ");
            Dictionary<string, int> occurancies = new Dictionary<string, int>();

            using(textReader)
            {
                string rawText = textReader.ReadToEnd().Replace("-", " ").Replace(".", " ").Replace(",", " ").Replace("?", " ").Replace("!", " ").ToLower();

                List<string> textToSingleWords = rawText.Split(" ").ToList();

                using(outputWriter)
                {
                    foreach (var word in textToSingleWords)
                    {
                        if (words.Contains(word) && !occurancies.ContainsKey(word))
                        {
                            occurancies.Add(word, 1);
                        }
                        else if (words.Contains(word) && occurancies.ContainsKey(word))
                        {
                            occurancies[word]++;
                        }
                    }
                    foreach (var word in occurancies.OrderBy(word => word.Value).Reverse())
                    {
                        outputWriter.WriteLine($"{word.Key} - {word.Value}");
                    }
                }
            }
        }
    }
}
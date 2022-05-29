namespace OddLines
{
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputPath = @"..\..\..\input.txt";
            string outputPath = @"..\..\..\output.txt";

            ExtractOddLines(inputPath, outputPath);
        }

        public static void ExtractOddLines(string inputPath, string outputPath)
        {
            StreamReader reader = new StreamReader(inputPath);

            using (reader)
            {
                StreamWriter writer = new StreamWriter(outputPath);

                using (writer)
                {
                    int lineCount = 0;

                    while (true)
                    {
                        string line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        if (lineCount % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }

                        lineCount++;
                    }

                }
            }
        }
    }
}

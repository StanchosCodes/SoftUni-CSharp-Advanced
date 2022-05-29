namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\input.txt";
            string outputPath = @"..\..\..\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputPath, string outputPath)
        {
            StreamReader reader = new StreamReader(inputPath);

            using (reader)
            {
                StreamWriter writer = new StreamWriter(outputPath);

                using (writer)
                {
                    int lineCounter = 0;
                    while (true)
                    {
                        lineCounter++;
                        string currLine = reader.ReadLine();

                        if (currLine == null)
                        {
                            break;
                        }

                        writer.WriteLine($"{lineCounter}. {currLine}");
                    }
                }
            }
        }
    }
}

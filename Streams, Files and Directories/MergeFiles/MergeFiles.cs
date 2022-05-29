using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main(string[] args)
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamReader firstReader = new StreamReader(firstInputFilePath);
            StreamReader secondReader = new StreamReader(secondInputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);

            using (firstReader)
            {
                int lineCounter = 0;

                using (writer)
                {
                    while (true)
                    {
                        lineCounter++;

                        string firstReaderLine = firstReader.ReadLine();
                        string secondReaderLine = secondReader.ReadLine();

                        if (firstReaderLine == null && secondReaderLine != null)
                        {
                            writer.WriteLine(secondReaderLine);
                            continue;
                        }
                        if (secondReaderLine == null && firstReaderLine != null)
                        {
                            writer.WriteLine(firstReaderLine);
                            continue;
                        }

                        if (firstReaderLine == null && secondReaderLine == null)
                        {
                            break;
                        }

                        writer.WriteLine(firstReaderLine);
                        writer.WriteLine(secondReaderLine);

                    }
                }
            }
        }
    }
}

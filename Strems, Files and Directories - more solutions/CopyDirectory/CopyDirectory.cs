namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath)) // if it exists we should delete it first
            {
                Directory.Delete(outputPath, true);
            }

            // Now we should create the directory
            Directory.CreateDirectory(outputPath);

            // Now we take all files in the input directory
            string[] files = Directory.GetFiles(inputPath);

            // Now copy every file in the output directory

            foreach (string file in files)
            {
                var fileName = Path.GetFileName(file); // We take its name so we can combine it with the output path
                var pathToCopyIn = Path.Combine(outputPath, fileName);

                File.Copy(fileName, pathToCopyIn); // Copying the file to the new directory
            }
        }
    }
}
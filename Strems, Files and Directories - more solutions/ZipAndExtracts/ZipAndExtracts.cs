namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"..\..\..\Files\copyMe.png";
            string zipArchiveFile = @"..\..\..\Files\archive.zip";
            string extractedFile = @"..\..\..\Files\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using (var archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create))
            {
                // We take the file which we will add to archive
                string fileName = Path.GetFileName(inputFilePath);

                // We create an entry of the file
                archive.CreateEntryFromFile(inputFilePath, fileName);
            }        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            var archive = ZipFile.OpenRead(zipArchiveFilePath);
            var fileToExtract = archive.GetEntry(fileName);

            fileToExtract.ExtractToFile(outputFilePath);
        }
    }
}

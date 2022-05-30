namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\copyMe.png";
            string outputFilePath = @"..\..\..\Files\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream reader = new FileStream(inputFilePath, FileMode.Open)) // read the input file
            {
                using (FileStream writer = new FileStream(outputFilePath, FileMode.Create)) // writting in the output file (copying in the output file)
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        int countReadBytes = reader.Read(buffer, 0, buffer.Length);

                        if (countReadBytes == 0) // if our file did not read any data then we break the cicle
                        {
                            break;
                        }

                        writer.Write(buffer, 0, countReadBytes);
                    }
                }
            }
        }
    }
}
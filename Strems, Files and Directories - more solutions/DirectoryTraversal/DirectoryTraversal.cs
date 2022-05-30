namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath); // Take the files names
            Dictionary<string, List<FileInfo>> extensionsInfo = new Dictionary<string, List<FileInfo>>(); // Extensions and files info
            StringBuilder sb = new StringBuilder();

            foreach (string file in files) // Taking the extension and the file info of each file
            {
                FileInfo fileInfo = new FileInfo(file); // Taking the file info
                string extension = fileInfo.Extension; // Taking the extension

                if (!extensionsInfo.ContainsKey(extension))
                {
                    extensionsInfo.Add(extension, new List<FileInfo>()); // Filling the extension to the dictionary
                }

                extensionsInfo[extension].Add(fileInfo); // Filling the file info for the given key to the dictionary

                foreach (var entryInfo in extensionsInfo.OrderByDescending(entry => entry.Value.Count).ThenBy(entry => entry.Key))
                // Sort by count of the list descending then by extension
                {
                    string currExtension = entryInfo.Key;
                    sb.AppendLine(currExtension);
                    List<FileInfo> filesInfo = entryInfo.Value; // Taking the list of files so we can sort it by size of the file
                    filesInfo.OrderByDescending(entry => entry.Length);

                    foreach (FileInfo infoOfFile in filesInfo)
                    {
                        sb.AppendLine($"--{infoOfFile.Name} - {infoOfFile.Length / 1024:f3}kb"); // 1024 bytes = 1 kb -> bytes / 1024 = kb
                    }
                }

            }
                return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string reportPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;

            File.WriteAllText(reportPath, textContent);
        }
    }
}

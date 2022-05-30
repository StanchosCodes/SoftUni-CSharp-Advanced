using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines
{
    public class EvenLines
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\..\Files\text.txt";

            string orderedText = ProcessLines(filePath);

            Console.WriteLine(orderedText);
        }

        public static string ProcessLines(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                int counter = -1;
                string line = reader.ReadLine();
                StringBuilder sb = new StringBuilder();

                while (line != null)
                {
                    counter++;

                    if (counter % 2 == 0)
                    {
                        line = Replace(line);
                        line = Reverse(line);

                        sb.Append(line);
                        sb.AppendLine();
                    }

                    line = reader.ReadLine();
                }
                string newText = sb.ToString();
                return newText;
            }
        }

        private static string Replace(string line)
        {
            return line.Replace("-", "@")
                 .Replace(",", "@")
                 .Replace(".", "@")
                 .Replace("!", "@")
                 .Replace("?", "@");
        }
        private static string Reverse(string line)
        {
            return string.Join(" ", line.Split().Reverse());
        }
    }
}

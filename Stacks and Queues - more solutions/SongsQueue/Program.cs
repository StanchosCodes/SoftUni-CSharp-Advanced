using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsSequence = Console.ReadLine().Split(", ");

            Queue<string> songs = new Queue<string>(songsSequence);

            while (songs.Count > 0)
            {
                string[] cmd = Console.ReadLine().Split(' ');

                string cmdArgs = cmd[0];

                if (cmdArgs == "Play")
                {
                    songs.Dequeue();
                }
                else if (cmdArgs == "Add")
                {
                    string song = string.Join(" ", cmd);
                    song = song.Substring(4);
                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (cmdArgs == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}

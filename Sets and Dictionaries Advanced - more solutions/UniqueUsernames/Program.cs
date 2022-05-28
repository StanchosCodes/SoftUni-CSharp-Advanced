using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> userNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string userName = Console.ReadLine();

                userNames.Add(userName);
            }

            foreach (string user in userNames)
            {
                Console.WriteLine(user);
            }
        }
    }
}

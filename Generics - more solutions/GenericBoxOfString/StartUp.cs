using System;

namespace GenericBoxOfString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 0; i < range; i++)
            {
                string input = Console.ReadLine();

                Box<string> newBox = new Box<string>(input);

                Console.WriteLine(newBox.ToString());
            }
        }
    }
}

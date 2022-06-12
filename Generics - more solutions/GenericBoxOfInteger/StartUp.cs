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
                int input = int.Parse(Console.ReadLine());

                Box<int> newBox = new Box<int>(input);

                Console.WriteLine(newBox);
            }
        }
    }
}

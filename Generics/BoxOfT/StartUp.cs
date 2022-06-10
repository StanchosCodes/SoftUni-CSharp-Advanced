using System;

namespace BoxOfT
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> newBox = new Box<int>();

            newBox.Add(1);
            newBox.Add(2);
            newBox.Add(3);
            Console.WriteLine(newBox.Remove());
            newBox.Add(4);
            newBox.Add(5);
            Console.WriteLine(newBox.Remove());
        }
    }
}

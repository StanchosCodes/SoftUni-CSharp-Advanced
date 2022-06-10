using System;

namespace GenericArrayCreator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var intArray = ArrayCreator.Create(10, 6);

            var stringArray = ArrayCreator.Create(6, "Stancho");

            Console.WriteLine(string.Join(" ", intArray));
            Console.WriteLine(string.Join(" ", stringArray));
        }
    }
}

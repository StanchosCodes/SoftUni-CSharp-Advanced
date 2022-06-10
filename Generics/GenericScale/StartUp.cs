using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // var isEqual = EqualityScale<int>.AreEqual(1, 1);
            EqualityScale<int> isEqual = new EqualityScale<int>(1, 1);

            Console.WriteLine(isEqual.AreEqual());
        }
    }
}

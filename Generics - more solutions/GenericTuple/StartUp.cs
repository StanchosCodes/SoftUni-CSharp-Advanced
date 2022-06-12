using System;
using System.Linq;

namespace GenericTuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string adress = personInfo[2];

            string[] personBeerInfo = Console.ReadLine().Split();
            string name = personBeerInfo[0];
            int littresBeer = int.Parse(personBeerInfo[1]);

            double[] intAndDouble = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int intValue = (int)intAndDouble[0];
            double doubleValue = intAndDouble[1];

            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, adress);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name, littresBeer);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(intValue, doubleValue);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}

using System;
using System.Linq;

namespace GenericThreeuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string adress = personInfo[2];
            string town = personInfo[3];

            string[] personBeerInfo = Console.ReadLine().Split();
            string name = personBeerInfo[0];
            int littresBeer = int.Parse(personBeerInfo[1]);
            string drunkOrNot = personBeerInfo[2] == "drunk" ? "True" : "False";

            string[] bankInfo = Console.ReadLine().Split();
            string person = bankInfo[0];
            double balance = double.Parse(bankInfo[1]);
            string bankName = bankInfo[2];

            Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>(fullName, adress, town);
            Threeuple<string, int, string> secondTuple = new Threeuple<string, int, string>(name, littresBeer, drunkOrNot);
            Threeuple<string, double, string> thirdTuple = new Threeuple<string, double, string>(person, balance, bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}

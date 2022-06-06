using System;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Stancho";
            person.Age = 23;

            Person person2 = new Person();
            Console.WriteLine($"Name: {person2.Name} -> Age: {person2.Age}");

            Person person3 = new Person(24);
            Console.WriteLine($"Name: {person3.Name} -> Age: {person3.Age}");

            Person person4 = new Person("Stancho", 23);
            Console.WriteLine($"Name: {person4.Name} -> Age: {person4.Age}");
        }
    }
}

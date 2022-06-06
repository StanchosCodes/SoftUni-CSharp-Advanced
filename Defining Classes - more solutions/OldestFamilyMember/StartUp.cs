using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            //Person person = new Person();

            //person.Name = "Stancho";
            //person.Age = 23;

            //Person person2 = new Person();
            //Console.WriteLine($"Name: {person2.Name} -> Age: {person2.Age}");

            //Person person3 = new Person(24);
            //Console.WriteLine($"Name: {person3.Name} -> Age: {person3.Age}");

            //Person person4 = new Person("Stancho", 23);
            //Console.WriteLine($"Name: {person4.Name} -> Age: {person4.Age}");

            int n = int.Parse(Console.ReadLine());

            List<Person> members = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string memberInfo = Console.ReadLine();

                string currName = memberInfo.Split()[0];
                int currAge = int.Parse(memberInfo.Split()[1]);

                Person currMember = new Person(currName, currAge);

                AddMember(currMember, members);
            }

            Person oldestPerson = GetOldestMember(members);
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }

        static void AddMember(Person member, List<Person> members)
        {
            members.Add(member);
        }

        static Person GetOldestMember(List<Person> members)
        {

            int age = members.Max(person => person.Age);

            int index = members.FindIndex(person => person.Age == age);

            Person person = members[index];

            return person;
        }
    }
}

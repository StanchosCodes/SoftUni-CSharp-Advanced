using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Read the people with there age
            List<Person> people = ReadPeople();

            // Read the condition and threshold for the sorting
            string condition = Console.ReadLine();
            int threshold = int.Parse(Console.ReadLine());
            Func<Person, bool> filter = PersonFilter(condition, threshold);

            // Filter all people with the created filter from the given condition and threshold
            List<Person> filterdPeople = people.Where(filter).ToList();

            // Print the filtered people in the given format
            string formatToPrint = Console.ReadLine();
            Action<Person> printerFormat = PersonPrinter(formatToPrint);
            PrintPeople(filterdPeople, printerFormat);
        }

        static List<Person> ReadPeople()
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] nameAge = Console.ReadLine().Split(", ");

                string name = nameAge[0];
                int age = int.Parse(nameAge[1]);

                people.Add(new Person (name, age));
            }

            return people;
        }

        static Func<Person, bool> PersonFilter(string condition, int threshold)
        {
            if (condition == "older")
            {
                return p => p.Age >= threshold;
            }
            if (condition == "younger")
            {
                return p => p.Age < threshold;
            }

            return null;
        }

        static Action<Person> PersonPrinter(string format)
        {
            if (format == "name age")
            {
                return (Person p) => Console.WriteLine($"{p.Name} - {p.Age}");
            }
            if (format == "name")
            {
                return (Person p) => Console.WriteLine($"{p.Name}");
            }
            if (format == "age")
            {
                return (Person p) => Console.WriteLine($"{p.Age}");
            }
            return null;
        }

        static void PrintPeople (List<Person> filteredPeople, Action<Person> printerFormat)
        {
            foreach (Person person in filteredPeople)
            {
                printerFormat(person);
            }
        }
    }
}

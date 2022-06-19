using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo(Person other)
        {
            int resultOfComaring = Name.CompareTo(other.Name);

            if (resultOfComaring == 0)
            {
                resultOfComaring = Age.CompareTo(other.Age);
            }

            if (resultOfComaring == 0)
            {
                resultOfComaring = Town.CompareTo(other.Town);
            }

            return resultOfComaring;
        }
    }
}

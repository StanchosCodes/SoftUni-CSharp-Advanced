using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string  Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            int resultOfComparing = Name.CompareTo(other.Name);

            if (resultOfComparing == 0)
            {
                resultOfComparing = Age.CompareTo(other.Age);
            }

            return resultOfComparing;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            Person other = obj as Person;

            if (other == null)
            {
                return false;
            }

            return Age == other.Age && Name == other.Name;
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    public class Box<T> : IComparable<T> where T : IComparable<T>
    {
        public T Element
        {
            get;
        }
        public List<T> Elements { get; }

        public Box(List<T> elements)
        {
            this.Elements = elements;
        }
        public Box(T element)
        {
            this.Element = element;
        }

        public int CompareTo(T other) => Element.CompareTo(other);

        public int CountOfGreaterElements<T>(List<T> list, T readLine) where T : IComparable
            => list.Count(word => word.CompareTo(readLine) > 0);

        //public override string ToString()
        //{
        //    return $"{typeof(T)}: {Element}";
        //}
    }
}

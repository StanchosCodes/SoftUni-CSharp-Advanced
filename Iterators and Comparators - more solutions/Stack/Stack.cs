using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> collection;

        public Stack(params T[] data)
        {
            collection = new List<T>(data);
        }

        public void Push(params T[] elementsToPush)
        {
            foreach (T element in elementsToPush)
            {
                collection.Add(element);
            }
        }

        public T Pop()
        {
            if (collection.Count == 0)
            {
                throw new ArgumentException("No elements");
            }

            T element = collection[collection.Count - 1];
            collection.RemoveAt(collection.Count - 1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

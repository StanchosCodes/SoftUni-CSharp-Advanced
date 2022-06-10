using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> boxCollection;

        public Box()
        {
            this.boxCollection = new List<T>();
        }
        public int Count
        {
            get
            {
                return this.boxCollection.Count;
            } 
        }

        public void Add(T element)
        {
            this.boxCollection.Add(element);
        }

        public T Remove()
        {
            if (this.boxCollection.Count == 0)
            {
                throw new InvalidOperationException("The box is empty");
            }

            var lastElement = this.boxCollection[this.boxCollection.Count - 1];
            this.boxCollection.RemoveAt(this.boxCollection.Count - 1);
            return lastElement;
        }
    }
}

using System.Collections.Generic;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        public T Element
        {
            get;
        }
        public List<T> Elements { get; set; }

        public Box(List<T> elements)
        {
            this.Elements = elements;
        }
        public Box(T element)
        {
            this.Element = element;
        }

        public int CountOfGreaterElements(List<double> elements, double elementToCompare)
        {
            int count = 0;

            //long elementToCompareValue = 0;
            //foreach (char letter in elementToCompare)
            //{
            //    elementToCompareValue += (int)letter;
            //}

            foreach (double element in elements)
            {
                //long elementValue = 0;

                //foreach (char letter in element)
                //{
                //    elementValue += (int)letter;
                //}

                //if (elementValue > elementToCompareValue)
                //{
                //    count++;
                //}

                if (element > elementToCompare)
                {
                    count++;
                }
            }

            return count;
        }

        //public override string ToString()
        //{
        //    return $"{typeof(T)}: {Element}";
        //}
    }
}

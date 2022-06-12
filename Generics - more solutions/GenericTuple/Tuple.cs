using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTuple
{
    public class Tuple<TFirst, TSecond>
    {
        public TFirst First { get; private set; }
        public TSecond Second { get; private set; }

        public Tuple(TFirst firstElement, TSecond secondElement)
        {
            this.First = firstElement;
            this.Second = secondElement;
        }

        public override string ToString()
        {
            return $"{First} -> {Second}";
        }
    }
}

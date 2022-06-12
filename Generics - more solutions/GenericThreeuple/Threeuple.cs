using System;
using System.Collections.Generic;
using System.Text;

namespace GenericThreeuple
{
    public class Threeuple<TFirst, TSecond, TThird>
    {
        public TFirst First { get; private set; }
        public TSecond Second { get; private set; }
        public TThird Third { get; private set; }

        public Threeuple(TFirst firstElement, TSecond secondElement, TThird thirdElement)
        {
            this.First = firstElement;
            this.Second = secondElement;
            this.Third = thirdElement;
        }

        public override string ToString()
        {
            return $"{First} -> {Second} -> {Third}";
        }
    }
}

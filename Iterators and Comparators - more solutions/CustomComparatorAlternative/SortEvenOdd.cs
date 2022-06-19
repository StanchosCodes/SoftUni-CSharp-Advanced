using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CustomComparatorAlternative
{
    public class SortEvenOdd : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            bool isXEven = x % 2 == 0;
            bool isYEven = y % 2 == 0;

            if (isXEven && isYEven)
            {
                return x.CompareTo(y);
            }
            else if (!isXEven && !isYEven)
            {
                return x.CompareTo(y);
            }
            else if (isXEven && !isYEven)
            {
                return -1;
            }
            else if (!isXEven && isYEven)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

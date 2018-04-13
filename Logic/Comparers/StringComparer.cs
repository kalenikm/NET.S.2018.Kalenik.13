using System;
using System.Collections.Generic;

namespace Logic.Comparers
{
    public class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return String.Compare(x, y, StringComparison.Ordinal);
        }
    }
}
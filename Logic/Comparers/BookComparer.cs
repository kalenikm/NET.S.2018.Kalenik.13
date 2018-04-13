using System;
using System.Collections.Generic;

namespace Logic.Comparers
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return String.Compare(x.Author, y.Author, StringComparison.Ordinal);
        }
    }
}
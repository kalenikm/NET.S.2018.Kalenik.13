using System;

namespace Logic
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public int CompareTo(Book item)
        {
            return String.CompareOrdinal(Title, item.Title);
        }
    }
}
using System;

namespace Algorithmus.Model
{
    public class Book
    : IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public DateTime Publish { get; set; }

        public int CompareTo(Book book) =>
            Author.CompareTo(book.Author) == 1 && Publish.CompareTo(book.Publish) == 0 ? 1 : 0;
        
    }
}

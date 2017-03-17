using System;
using System.Collections.Generic;

namespace ISP._2_after
{
    public class Library
    {
        List<Book> _books = new List<Book>(6);

        public IReadOnlyList<Book> GetBooks()=> _books.AsReadOnly();
        
        public void Add(Book book)
        {
            _books.Add(book);
        }

        public String dumpContents()
        {
            string dumps="";

            foreach (Book book in _books)
            {
                dumps = dumps + book.GetSummary();
                dumps = dumps + "\n";

            }
            return dumps;
        }

    }
}

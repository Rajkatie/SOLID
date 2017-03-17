using ISP._2_after;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class BookStats
    {

    }
    public class Library
    {

        List<Book> _books = new List<Book>();

        public List<Book> getBooks()
        {            
            return _books;
        }

        public void addBook(Book book)
        {
             _books.Add(book);
        }
    }
    
}

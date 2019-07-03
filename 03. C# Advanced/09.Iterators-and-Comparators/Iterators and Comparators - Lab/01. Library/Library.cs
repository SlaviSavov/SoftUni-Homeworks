using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Library
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public IEnumerator<Book> GetEnumerator()
        {

            var libraryEnumerator=new LibraryIterator (books);
            return libraryEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator() ;
        }
        public Library()
        {

        }
        public Library(params Book[] books)
        {
            this.books = books.ToList();
            this.books.Sort(new BookComparator());
        }
    }
}

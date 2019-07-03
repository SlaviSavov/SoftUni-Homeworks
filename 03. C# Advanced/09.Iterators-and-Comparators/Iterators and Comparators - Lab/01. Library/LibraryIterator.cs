using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01._Library
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private int currentIndex;

        private  List<Book> books;
        public Book Current => books[currentIndex];     

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return ++currentIndex < books.Count;  
        }

        public void Reset()
        {
            currentIndex = -1;
        }
        public LibraryIterator(List<Book > books)
        {
            this.books = books;
            Reset(); 
        }
    }
}

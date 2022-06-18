using IteratorsAndComparators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            List<Book> bookList = this.books.OrderBy(book => book).ToList();
            for (int i = 0; i < bookList.Count; i++)
            {
                yield return bookList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //public IEnumerator<Book> GetEnumerator()
        //{
        //    return new LibraryIterator(this.books);
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

        //class LibraryIterator : IEnumerator<Book>
        //{
        //    private List<Book> books;
        //    private int position;

        //    public LibraryIterator(List<Book> books)
        //    {
        //        this.books = books;
        //        Reset();
        //    }
        //    public Book Current => this.books[position];

        //    object IEnumerator.Current => this.Current;

        //    public void Dispose()
        //    {
        //    }

        //    public bool MoveNext()
        //    {
        //        this.position++;
        //        return position < books.Count;
        //    }

        //    public void Reset()
        //    {
        //        this.position = -1;
        //    }
        //}
    }
}

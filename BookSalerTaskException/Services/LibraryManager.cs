using BookSalerTaskException.Enums;
using BookSalerTaskException.Exceptions;
using BookSalerTaskException.Interfaces;
using BookSalerTaskException.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalerTaskException.Services
{
    class LibraryManager : ILibraryManager
    {
        private List<Book> _books;
        public List<Book> Books => _books;
        public LibraryManager()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {

            _books.Add(_books.Find(b => b.Name == book.Name) == null ? book :
                throw new SameBookalreadyAddedExpection("Book alredy added", new SameBookalreadyAddedExpection("bu adda kitab yarada bilmersen")));
        }

        public List<Book> Filter(string searchAuthor, string searchGenre)
        {
            return _books.FindAll(book => book.Author.ToLower() == searchAuthor.ToLower() && book.GenreType.ToString().ToLower() == searchGenre.ToLower());
        }

        public Book ShowInfo(string name)
        {
            return _books.Find(book => book.Name.ToLower() == name.ToLower())
                ?? throw new BookNotFoundException("Not found book ",
                    new BookNotFoundException("kitabin adin duzelt"));
        }


        public List<Book> Search(string search)
        {
            return _books.FindAll(book => book.Name.ToLower() == search.ToLower() ||
            book.Author.ToLower() == search.ToLower() ||
            book.PageCount.ToString() == search.ToLower() ||
            book.GenreType.ToString() == search.ToLower());
        }


    }
}

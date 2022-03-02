using BookSalerTaskException.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalerTaskException.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books { get; }

        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(string search);
        List<Book> Filter(string searchAuthor, string searchGenre);

    }
}

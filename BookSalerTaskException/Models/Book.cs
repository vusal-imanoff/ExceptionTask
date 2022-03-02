using BookSalerTaskException.Enums;
using BookSalerTaskException.Interfaces;
using BookSalerTaskException.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalerTaskException.Models
{
    class Book : LibraryManager
    {
        //private GroupType groupType;

        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public GenreType GenreType { get; set; }
        public Book(string name,string author, int pageCount,GenreType genreType)
        {
            Name = name;
            Author = author;
            PageCount = pageCount;
            GenreType = genreType;

        }

        public override string ToString()
        {
            return $"Adi- {Name}\nYazici- {Author}\nSehifesi- {PageCount}\nJanri- {GenreType}\n";
        }

    }
}

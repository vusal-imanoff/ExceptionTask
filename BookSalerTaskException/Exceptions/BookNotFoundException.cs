using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalerTaskException.Exceptions
{
    class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message): base(message)
        {

        } 
        public BookNotFoundException(string message, BookNotFoundException bookNotFoundException) : base(message, bookNotFoundException)
        {

        }
    }
}

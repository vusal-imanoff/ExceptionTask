using BookSalerTaskException.Enums;
using BookSalerTaskException.Services;
using BookSalerTaskException.Models;
using BookSalerTaskException.Exceptions;
using System;

namespace BookSalerTaskException
{
    class Program
    {

        static void Main(string[] args)
        {
            LibraryManager libraryManager = new LibraryManager();

            
            do
            {
                Console.WriteLine("1.Kitab yarat");
                Console.WriteLine("2.ShowInfo");
                Console.WriteLine("3.ShowBook");
                Console.WriteLine("4.search");
                Console.WriteLine("5.Filter");
                Console.WriteLine("6.Cixis");

                string str = Console.ReadLine();
                int changed;

                while (!int.TryParse(str, out changed) || changed < 1 || changed > 6)
                {
                    Console.WriteLine("Duzgun Secim Edin");
                    str = Console.ReadLine();
                }

                switch (changed)
                {
                    case 1:
                        AddBook(ref libraryManager);
                        break;
                    case 2:
                        ShowInfo(ref libraryManager);
                        break;
                    case 3:
                        ShowBook(ref libraryManager);
                        break;
                    case 4:
                        Search(ref libraryManager);
                        break;
                    case 5:
                        Filter(ref libraryManager);
                        break;
                    case 6:
                        return;
                }

            } while (true);
            

        }

        
        
        public static void AddBook(ref LibraryManager libraryManager)
        {
            Console.WriteLine("kitabin adin daxil et: ");
            string name = Console.ReadLine();

            Console.WriteLine("Kitabin muellifin daxil et: ");
            string author = Console.ReadLine();

            Console.WriteLine("Kitabin sehifesin daxil et: ");
            string strpageCount = Console.ReadLine();
            int pageCount;
            while (!int.TryParse(strpageCount, out pageCount))
            {
                Console.WriteLine("sehifesin duzgun daxil et: ");
                strpageCount = Console.ReadLine();
            }
            Console.WriteLine("Janr Novunu Sec");
            foreach (var item in Enum.GetValues(typeof(GenreType)))
            {
                Console.WriteLine($"{(int)item} {item}");
            }
            string genreTypeStr = Console.ReadLine();
            int genreTypenum;

            while (!int.TryParse(genreTypeStr, out genreTypenum))
            {
                Console.WriteLine("Duzgun Qrup Novu Sec:");
                genreTypeStr = Console.ReadLine();
            }
            GenreType genreType = (GenreType)genreTypenum;

            Book book = new Book(name, author, pageCount, genreType);
            libraryManager.Add(book);
        }
        public static void ShowInfo(ref LibraryManager libraryManager)
        {
            if (libraryManager.Books.Count > 0)
            {
                foreach (Book book in libraryManager.Books)
                {
                    Console.WriteLine(book); ;
                }
            }
            else
            {
                Console.WriteLine("Kitab yarat");
            }
            Console.WriteLine("Kitabin adin daxil edin");
            string srchstr = Console.ReadLine();
            Console.WriteLine(libraryManager.ShowInfo(srchstr));
        }
        public static void ShowBook(ref LibraryManager libraryManager)
        {
            foreach (Book book in libraryManager.Books)
            {
                Console.WriteLine(book);
            }
        }
        public static void Search(ref LibraryManager libraryManager)
        {
            if (libraryManager.Books.Count > 0)
            {
                foreach (Book book in libraryManager.Books)
                {
                    Console.WriteLine(book); ;
                }
            }
            else
            {
                Console.WriteLine("Kitab yarat");
            }
            Console.WriteLine("axtaracaginiz sozu daxil edin: ");
            string search = Console.ReadLine();
            if (libraryManager.Search(search)!=null)
            {
                foreach (Book book in libraryManager.Search(search))
                {
                    Console.WriteLine(book);
                }
            }
            Console.WriteLine(libraryManager.Search(search));
        }
        public static void Filter(ref LibraryManager libraryManager)
        {
            if (libraryManager.Books.Count>0)
            {
                foreach (Book book in libraryManager.Books)
                {
                    Console.WriteLine(book); ;
                }
            }
            else
            {
                Console.WriteLine("Kitab yarat");
            }
            Console.WriteLine("Yazici adin daxil edin");
            string author = Console.ReadLine();
            Console.WriteLine("Janri daxil edin: ");
            string genre = Console.ReadLine();
            if (libraryManager.Filter(author,genre) != null)
            {
                foreach (Book book in libraryManager.Filter(author, genre))
                {
                    Console.WriteLine(book);
                }
            }
            libraryManager.Filter(author, genre);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.BusinessLogic
{
    public class BookAdder
    {
        public static void CreateBook(string book_name, string book_genre, int book_year, string book_description )
        {
           
            Book data = new Book
            {
                BookName = book_name,
                BookGenre = book_genre,
                BookYear = book_year,
                BookDescription = book_description
            };
            using (LibraryContext libraryContextBooks = new LibraryContext())
            {
                libraryContextBooks.Books.Add(data);
                libraryContextBooks.SaveChanges();
            }
        }

        public static IEnumerable<Book> LoadBooks()
        {
            LibraryContext context = new LibraryContext();
            var books = context.Books;

            return books;
        }
    }
}
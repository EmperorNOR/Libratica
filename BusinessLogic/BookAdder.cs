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
        //Create a book entry in the database based on form input.
        public static void CreateBook(string book_name, string book_genre, int book_year, string book_description )
        {
           
            Book data = new Book
            {
                book_name = book_name,
                book_genre = book_genre,
                book_year = book_year,
                book_description = book_description
            };
            using (LibraryContext libraryContextBooks = new LibraryContext())
            {
                libraryContextBooks.Books.Add(data);
                libraryContextBooks.SaveChanges();
            }
        }
        //Load every book in the database to a Ienumerable that gets returned to the controller.
        public static IEnumerable<Book> LoadBooks()
        {
            LibraryContext context = new LibraryContext();
            var books = context.Books;

            return books;
        }
    }
}
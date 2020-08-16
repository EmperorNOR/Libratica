using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Library.Models;

namespace Library.BusinessLogic
{
    public class RentBook
    {
        public static void RentingBook(int user_id, int book_id)
        {

            UsersHasBooksModel data = new UsersHasBooksModel
            {
                users_user_id = user_id,
                books_book_id = book_id
            };
            using (LibraryContext libraryContextBooks = new LibraryContext())
            {
                libraryContextBooks.UsersBooks.Add(data);
                libraryContextBooks.SaveChanges();
            }
        }
    }
}
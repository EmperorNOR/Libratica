using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.ViewModels
{
    public class LibraticaViewModel
    {
        public List<Book> Books { get; set;}
        public List<User> Users { get; set; }
        public List<UsersHasBooksModel> usersHasBooks { get; set; }

    }
}
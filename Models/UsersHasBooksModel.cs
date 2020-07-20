using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    [Table("users_has_books")]
    public class UsersHasBooksModel
    {

        [Key]
        [Column("users_user_id", Order = 0)]
        public int users_user_id { get; set; }

        [Key]
        [Column("books_book_id", Order = 1)]
        public int books_book_id { get; set; }
    }
}
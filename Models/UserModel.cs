using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }
        [Required]
        public string user_name { get; set; }
        public int user_age { get; set; }
        public string user_adress { get; set; }
        public int user_zipcode { get; set; }
        public string user_mail { get; set; }
        public string user_password { get; set; }
        public int user_books { get; set; }
        public virtual IList<Book> Books { get; set; }
    }
}
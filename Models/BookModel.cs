using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [Table("books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("book_id")]
        public int BookId { get; set; }


        [Required(ErrorMessage = "You must fill in this field with a valid input")]
        [Column("book_name")]
        [Display(Name = "Name")]
        public string BookName { get; set; }


        [Required(ErrorMessage = "You must fill in this field with a valid input")]
        [Column("book_genre")]
        [Display(Name = "Genre")]
        public string BookGenre { get; set; }


        [Required(ErrorMessage = "You must fill in this field with a valid input")]
        [Column("book_year")]
        [Display(Name = "Year of Release YYYY")]
        public int BookYear { get; set; }


        [Required(ErrorMessage = "You must fill in this field with a valid input")]
        [Column("book_description")]
        [Display(Name = "Description")]
        public string BookDescription { get; set; }


        public IList<User> Users { get; set; }
    }
}
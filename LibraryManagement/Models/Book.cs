using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Názov knihy je povinný.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Dátum vydania je povinný.")]
        public DateTime PublishedDate { get; set; }

        public string Genre { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
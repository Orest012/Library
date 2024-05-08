using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Book
    {
        [Key]
        public int IdBook { get; set; }
        public string Title { get; set; }
        [MaxLength(20)]
        [Required]
        public string ISBN { get; set; }
        public int Price { get; set; }
        [NotMapped]
        public string PriceRange { get; set; }


        public BookDetail BookDetail { get; set; }

        public List<BookAuthorMap> BookAuthorMap { get; set; }

        //[ForeignKey("Author")]
        //public int Author_Id { get; set; }
        //public Author Author { get; set; }


        //[ForeignKey("Publisher")]
        //public int Publisher_Id { get; set; }
        //public Publisher Publisher { get; set; }
        //public object Publisher { get; set; }
    }

}

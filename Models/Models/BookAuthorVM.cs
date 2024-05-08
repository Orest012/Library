using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class BookAuthorVM
    {
        [Key]
        public int IdBook { get; set; }
        public Book Book { get; set; }

        public List<Author> AuthorList { get; set; }
    }
}

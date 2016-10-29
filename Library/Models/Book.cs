using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {
    public class Book {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int ISBN { get; set; }
        public string Description { get; set; }
        public virtual Author Author { get; set; }
        public ICollection<BookCopy> BookCopies { get; set; }

        public override string ToString() {
            return String.Format("[{0}] -- {1}", this.Id, this.Title);
        }
    }
}

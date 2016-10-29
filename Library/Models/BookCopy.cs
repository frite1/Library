using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class BookCopy
    {
        [Key]
        public int Id { get; set; }
        public virtual Book Book { get; set; }
        public bool Available { get; set; }
    }
}
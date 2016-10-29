using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Member
    {
        [Key]
        public int MemId { get; set; }
        public int PersId { get; set; }
        public string Name { get; set; }
        public int Debt { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
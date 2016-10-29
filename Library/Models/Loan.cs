using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Library.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        public DateTime TimeOfLoan { get; set;} 
        public bool DueDate { get; set; }
        public int CountDaysOverDue { get; set; }
        public bool ActiveLoan { get; set; }
        public DateTime TimeOfReturn { get; set; }
        public virtual BookCopy BookCopy { get; set; }
        public virtual Member Member { get; set; }
    }
}
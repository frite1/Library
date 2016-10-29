using System;
using System.Collections.Generic;
using System.Linq;
using Library.Models;

namespace Library.Repositories
{
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext _context;

        public LoanRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Loan> All()
        {
            return _context.Loans.ToList();
        }

        public void Add(Loan Loan)
        {
            _context.Loans.Add(Loan);
            _context.SaveChanges();
        }

        public void Remove(Loan Loan)
        {
            _context.Loans.Remove(Loan);
            _context.SaveChanges();
        }

        public void Edit(Loan loan)
        {
            Loan orginalLoan = new Loan();
            orginalLoan.TimeOfLoan = loan.TimeOfLoan;
            orginalLoan.TimeOfReturn = loan.TimeOfReturn;
            orginalLoan.DueDate = loan.DueDate;
            orginalLoan.BookCopy = loan.BookCopy;
            _context.SaveChanges();
        }

        public Loan Find( int id)
        {
            Loan loan = _context.Loans.Find(id);
            return loan;
        }
    }
}
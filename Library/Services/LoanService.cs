using System;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class LoanService : IService
    {
        LoanRepository _loanRepository;

        public event EventHandler Updated;
        public LoanService(RepositoryFactory repoFactory)
        {
            _loanRepository = repoFactory.GetLoanRepository();
        }

        public IEnumerable<Loan> All()
        {
            return _loanRepository.All();
        }

        public void MakeLoan(Member member, BookCopy bookCopy)
        {
            Loan loan = new Loan();
            loan.TimeOfLoan = DateTime.Now;
            loan.TimeOfReturn = loan.TimeOfLoan.AddDays(15);
            loan.DueDate = false;
            loan.Member = member;
            loan.BookCopy = bookCopy;
            _loanRepository.Add(loan);
        }

        public void EndLoan(Loan loan)
        {
            //Jämför dagens datum med timeOfreturn
            int x = DateTime.Compare(loan.TimeOfReturn, DateTime.Now);
            //Om det gått för lång tid så sätt duedat till true
            if (x < 0)
            {
                loan.DueDate = true;
                LoanPassedDueDate(loan);
            }
            else
            {
                loan.Member = null; //ändra??
            }
            loan.BookCopy.Available = true;
            //_loanRepository.Remove(loan);
        }

        public void LoanPassedDueDate(Loan loan)
        {
            int x = (DateTime.Now - loan.TimeOfReturn).Days;
            loan.Member.Debt = x*10;
        }
    }
}
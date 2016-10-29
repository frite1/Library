using System;
using System.Collections.Generic;
using System.Linq;
using Library.Models;

namespace Library.Repositories
{
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<BookCopy> All()
        {
            return _context.BookCopies.ToList();
        }

        public void Add(BookCopy BookCopy)
        {
            _context.BookCopies.Add(BookCopy);
            _context.SaveChanges();
        }

        public void Remove(BookCopy BookCopy)
        {
            _context.BookCopies.Remove(BookCopy);
            _context.SaveChanges();
        }

        public void Edit(BookCopy bookCopy)
        {
            BookCopy orginalBookCopy = Find(bookCopy.Id);
            orginalBookCopy.Book = bookCopy.Book;
            _context.SaveChanges();
        }

        public BookCopy Find(int id)
        {
            BookCopy bookCopy = _context.BookCopies.Find(id);
            return bookCopy;
        }
    }
}
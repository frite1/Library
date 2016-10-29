using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories {
    public class BookRepository : IRepository<Book, int> {
        LibraryContext _context;

        public BookRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public IEnumerable<Book> All() {
            return _context.Books.ToList();
        }

        public void Add(Book Book)
        {
            _context.Books.Add(Book);
            _context.SaveChanges();
        }

        public void Remove(Book Book)
        {
            _context.Books.Remove(Book);
            _context.SaveChanges();
        }

        public void Edit(Book Book)
        {
            Book orginalBook = Find(Book.Id);
            orginalBook.Description = Book.Description;
            orginalBook.Title = Book.Title;
            orginalBook.ISBN = Book.ISBN;
            orginalBook.Author = Book.Author;
            orginalBook.BookCopies = Book.BookCopies;
            _context.SaveChanges();
        }

        public Book Find(int id)
        {   
           Book book = _context.Books.Find(id);
            return book;
        }

        public List<Book> GetByAuthor(Author author)
        {
            var query = _context.Books.Where(x => x.Author == author);
            return query.ToList();
        }
    }
}
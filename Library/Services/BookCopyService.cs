using System;
using System.Collections.Generic;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class BookCopyService : IService
    {
        BookCopyRepository _bookCopyRepository;

        public event EventHandler Updated;
        public BookCopyService(RepositoryFactory repoFactory)
        {
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
        }

        public IEnumerable<BookCopy> All()
        {
            return _bookCopyRepository.All();
        }

        public void AddBookCopy(Book book)
        {
            BookCopy bookCopy = new BookCopy();
            bookCopy.Book = book;
            //book.BookCopies++;
            _bookCopyRepository.Add(bookCopy);
        }
    }
}
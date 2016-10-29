using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services {
    class BookService : IService
    {
        BookRepository _bookRepository;



        public BookService(RepositoryFactory repoFactory)
        {
            _bookRepository = repoFactory.GetBookRepository();
        }

        public IEnumerable<Book> All()
        {
            return _bookRepository.All();
        }

        public void AddBook(string title, int isbn, string description, Author author)
        {
            EventArgs a = new EventArgs();
            Book book = new Book();

            book.Title = title;
            book.ISBN = isbn;
            book.Description = description;
            book.Author = author;

            _bookRepository.Add(book);

            OnUpdated(EventArgs.Empty);

            //fixa exception
        }

        public void RemoveBook(Book book)
        {
            _bookRepository.Remove(book);
        }

        public int NumberOfBookCopies(Book book)
        {
            int numberOfBookCopies = 0;
            foreach (var v in book.BookCopies)
            {
                numberOfBookCopies++;
            }
            return numberOfBookCopies;
        }

        public void ListBooksByAuthor(Author author)
        {
            _bookRepository.GetByAuthor(author);
        }



        public virtual void OnUpdated(EventArgs e)
        {
            EventHandler handler = Updated;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public event EventHandler Updated;

    }
}

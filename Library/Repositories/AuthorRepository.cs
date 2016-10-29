using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Library.Models;

namespace Library.Repositories
{
    public class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext _context;

        public AuthorRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Author> All()
        {
            return _context.Authors.ToList();
        }

        public void Add(Author Author)
        {
            _context.Authors.Add(Author);
            _context.SaveChanges();
        }

        public void Remove(Author Author)
        {
            _context.Authors.Remove(Author);
            _context.SaveChanges();
        }

        public void Edit(Author author)
        {
            Author originalAuthor = Find(author.Id);
            originalAuthor.Name = author.Name;
            _context.SaveChanges();
        }

        public Author Find(int id)
        {
            Author author = _context.Authors.Find(id);
            return author;
        }

        public Author FindAuthorByName(string name)
        {
            var authors = All();
            Author a = null;
            try
            {
                foreach (var author in authors)
                {
                    if (author.Name == name)
                    {
                        a = Find(author.Id);
                        return a;
                    }
                }
            }
            catch (NullReferenceException)
            {
                
            }
            return a;
        }

    }
}
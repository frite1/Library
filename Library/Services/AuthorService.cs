using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class AuthorService : IService
    {
        AuthorRepository _authorRepository;

        public event EventHandler Updated;
        public AuthorService(RepositoryFactory repoFactory)
        {
            _authorRepository = repoFactory.GetAuthorRepository();
        }

        public IEnumerable<Author> All()
        {
            return _authorRepository.All();
        }

        public void AddAuthor(string name)
        {
            Author author = new Author();
            author.Name = name;
            _authorRepository.Add(author);
            EventArgs args = new EventArgs();
            OnUpdated(args);
        }

        public Author GetAuthor(string name)
        {
            var author = _authorRepository.FindAuthorByName(name);
            return author;
        }
        public virtual void OnUpdated(EventArgs e)
        {
            if (Updated != null)
            {
                Updated(this, e);
            }
        }

    }
}
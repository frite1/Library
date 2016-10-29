using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Derived database strategy
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseIfModelChanges<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);

            LibraryContext db = new LibraryContext();

            Author alexDumas = new Author()
            {
                Name = "Alexandre Dumas"
            };

            Author astridLindgren = new Author()
            {
                Name = "Astrid Lindgren"
            };

            Book pippiLangstrump = new Book()
            {
                Title = "Pippi Långstrum",
                Author = astridLindgren
            };

            Book monteCristo = new Book() {
                Title = "The Count of Monte Cristo",
                Author = alexDumas
            };

            // Add the book to the DbSet of books.
            context.Books.Add(monteCristo);
            context.Books.Add(pippiLangstrump);
            /*db.Books.Add(monteCristo);
            db.Books.Add(pippiLangstrump);*/

            // Persist changes to the database
            context.SaveChanges();
            //db.SaveChanges();
        }
    }
}

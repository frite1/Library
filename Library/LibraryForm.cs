using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library {
    public partial class LibraryForm : Form {

        BookService _bookService;

        public LibraryForm()
        {
            InitializeComponent();

            RepositoryFactory repoFactory = new RepositoryFactory();
            _bookService = new BookService(repoFactory);
            //_loanService = new LoanService(repoFactory);

            _bookService.Updated += _bookService_Updated;
            //_loanService.Updated += _loanService_Updated;

            ListAllBooks();
        }
        
        

        private void _loanService_Updated(object sender, EventArgs e)
        {
            ListAllBooks();
        }
        private void _bookService_Updated(object sender, EventArgs e)
        {
            ListAllBooks();

        }

        private void ListAllBooks() {
            foreach (Book book in _bookService.All()) {
                lbBooks.Items.Add(book);
            }
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            var form = new BookPopup();
            form.ShowDialog(this);
        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveBookBtn_Click(object sender, EventArgs e)
        {
            var selected = (Book) lbBooks.SelectedItem;
            _bookService.RemoveBook(selected);
        }

        private void AddAuthorBtn_Click(object sender, EventArgs e)
        {
            var form = new AuthorPopup();
            form.ShowDialog(this);
        }
    }
}

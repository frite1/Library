using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AuthorPopup : Form
    {
        private AuthorService authorService;
        private RepositoryFactory repoFactory;
        private BookService bookService;
        public AuthorPopup()
        {
            InitializeComponent();
            repoFactory = new RepositoryFactory();
            authorService = new AuthorService(repoFactory);
            bookService = new BookService(repoFactory);
            //authorService.Updated += AuthorServiceOnUpdated;
        }

        private void AuthorServiceOnUpdated(object sender, EventArgs eventArgs)
        {
            
        }

        private void AddAuthorBtn_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            authorService.AddAuthor(name);
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

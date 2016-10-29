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
    
    public partial class BookPopup : Form
    {
        RepositoryFactory repoFactory;
        BookService bookService;
        AuthorService authorService;

        public BookPopup()
        {
            InitializeComponent();
            repoFactory = new RepositoryFactory();
            bookService = new BookService(repoFactory);
            authorService = new AuthorService(repoFactory);
            //authorService.Updated += authorService_Updated;
            GetAllAuthors();
        }


        //private void authorService_Updated(object sender, EventArgs eventArgs)
        //{
        //    GetAllAuthors();
        //}

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            int ISBN = Int32.Parse(textBox1.Text);
            string title = textBox2.Text;
            string author = AuthorComboBox.SelectedItem.ToString();
            Author _author = authorService.GetAuthor(author);
            string description = bookDescriptionBox.Text;

            bookService.AddBook(title, ISBN, description, _author);

        }

        public void GetAllAuthors()
        {
            var allAuthors = authorService.All();
            foreach (var author in allAuthors)
            {
                AuthorComboBox.Items.Add(author.Name);
            }
        }

        private void IsbnBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookDescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAuthorBtn_Click(object sender, EventArgs e)
        {            
            string authorName = AuthorComboBox.SelectedItem.ToString();
            authorService.AddAuthor(authorName);
        }

        public string SendInfo()
        {
            return textBox2.Text;
        }


        private void closeBookBtn_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void AuthorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

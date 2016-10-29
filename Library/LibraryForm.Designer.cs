namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.AddBook = new System.Windows.Forms.Button();
            this.RemoveBookBtn = new System.Windows.Forms.Button();
            this.AddAuthorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(26, 58);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(322, 160);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(26, 267);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(75, 23);
            this.AddBook.TabIndex = 1;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // RemoveBookBtn
            // 
            this.RemoveBookBtn.Location = new System.Drawing.Point(143, 267);
            this.RemoveBookBtn.Name = "RemoveBookBtn";
            this.RemoveBookBtn.Size = new System.Drawing.Size(88, 23);
            this.RemoveBookBtn.TabIndex = 4;
            this.RemoveBookBtn.Text = "Remove Book";
            this.RemoveBookBtn.UseVisualStyleBackColor = true;
            this.RemoveBookBtn.Click += new System.EventHandler(this.RemoveBookBtn_Click);
            // 
            // AddAuthorBtn
            // 
            this.AddAuthorBtn.Location = new System.Drawing.Point(446, 145);
            this.AddAuthorBtn.Name = "AddAuthorBtn";
            this.AddAuthorBtn.Size = new System.Drawing.Size(75, 23);
            this.AddAuthorBtn.TabIndex = 5;
            this.AddAuthorBtn.Text = "Add Author";
            this.AddAuthorBtn.UseVisualStyleBackColor = true;
            this.AddAuthorBtn.Click += new System.EventHandler(this.AddAuthorBtn_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 381);
            this.Controls.Add(this.AddAuthorBtn);
            this.Controls.Add(this.RemoveBookBtn);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.lbBooks);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button RemoveBookBtn;
        private System.Windows.Forms.Button AddAuthorBtn;
    }
}


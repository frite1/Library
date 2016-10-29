namespace Library
{
    partial class BookPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.closeBookBtn = new System.Windows.Forms.Button();
            this.labelISBN = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.IsbnBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(11, 297);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBookBtn.TabIndex = 4;
            this.AddBookBtn.Text = "Add";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // closeBookBtn
            // 
            this.closeBookBtn.Location = new System.Drawing.Point(139, 297);
            this.closeBookBtn.Name = "closeBookBtn";
            this.closeBookBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBookBtn.TabIndex = 5;
            this.closeBookBtn.Text = "Close";
            this.closeBookBtn.UseVisualStyleBackColor = true;
            this.closeBookBtn.Click += new System.EventHandler(this.closeBookBtn_Click);
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(12, 9);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 6;
            this.labelISBN.Text = "ISBN";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 48);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // bookDescriptionBox
            // 
            this.bookDescriptionBox.Location = new System.Drawing.Point(11, 192);
            this.bookDescriptionBox.Name = "bookDescriptionBox";
            this.bookDescriptionBox.Size = new System.Drawing.Size(203, 99);
            this.bookDescriptionBox.TabIndex = 10;
            this.bookDescriptionBox.Text = "";
            this.bookDescriptionBox.TextChanged += new System.EventHandler(this.bookDescriptionBox_TextChanged);
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(13, 103);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(201, 21);
            this.AuthorComboBox.TabIndex = 13;
            this.AuthorComboBox.SelectedIndexChanged += new System.EventHandler(this.AuthorComboBox_SelectedIndexChanged);
            // 
            // BookPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 339);
            this.Controls.Add(this.AuthorComboBox);
            this.Controls.Add(this.bookDescriptionBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.closeBookBtn);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "BookPopup";
            this.Text = "BookPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Button closeBookBtn;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox bookDescriptionBox;
        private System.Windows.Forms.ComboBox AuthorComboBox;
    }
}
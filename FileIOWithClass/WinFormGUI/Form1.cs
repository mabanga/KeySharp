using System;
using System.Windows.Forms;
using System.IO;
using LibrayIO.Models;
using System.Collections.Generic;
using System.Linq;

namespace WinFormGUI
{
    public partial class MainForm : Form
    {
        string path = @"C:\res\intec\FileIOWithClass\WinFormGUI\bin\Debug\WinBook.txt";
        List<Book> books = new List<Book>();

        public MainForm()
        {
            InitializeComponent();
        }
        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                books = Services.PopulateBooks();
                Services.WriteToFile(books, path);
                MessageBox.Show("File Created");
            }
            else
            {
                MessageBox.Show("File already exits");
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            lstShow.Items.Clear();
            lstMontre.Items.Clear();
            books = Services.ReadFromFile(path);
            foreach (var item in books)
            {
                lstShow.Items.Add(item.ToString());
                lstMontre.Items.Add(item.ToString());
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lstShow.Items.Clear();
            lstMontre.Items.Clear();
            List<Book> SortedList = books;
            //SortedList.Sort();
            //List<Book> SortedBooks = books.OrderBy(book => book.Author).ToList();
            SortedList = books.OrderBy(book => book.Author).ToList();

            foreach (var item in SortedList)
            {
                lstShow.Items.Add(item.ToString());
                lstMontre.Items.Add(item.ToString());
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmCreateBook frmCreateBook = new frmCreateBook();
            frmCreateBook.Show();
        }
    }
}

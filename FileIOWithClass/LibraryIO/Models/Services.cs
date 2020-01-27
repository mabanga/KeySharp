using System;
using System.Collections.Generic;
using System.IO;

namespace LibrayIO.Models
{
    public class Services
    {
        public static List<Book> PopulateBooks() 
        {
            List<Book> books = new List<Book>();
            books.Add(new Book());
            books.Add(new Book( "titre0", "zeric0", 2020));
            books.Add(new Book( "titre1", "aeric1", 2021));
            books.Add(new Book( "titre2", "ceric2", 2022));
            books.Add(new Book( "titre3", "beric3", 2023));
            return books;
        }
        public static List<Book> ReadFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                List<Book> lines = new List<Book>();
                while (!sr.EndOfStream)
                {
                    Book b = new Book();
                    b.Title = sr.ReadLine();
                    b.Author = sr.ReadLine();
                    b.Year = Convert.ToInt32(sr.ReadLine());
                    lines.Add(b);
                }
                return lines;
            }

        }
        public static void WriteToFile(List<Book> books, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                for (int index = 0; index < books.Count; index++)
                {
                    sw.WriteLine(books[index].Title);
                    sw.WriteLine(books[index].Author);
                    sw.WriteLine(books[index].Year);
                }
            }
        }
        public static void WriteToFileOneBook(Book book, string path)
        {
            using (StreamWriter sw =new StreamWriter(path, true))
            {
                Book b = new Book();
                sw.WriteLine(b.Title = book.Title);
                sw.WriteLine(b.Author = book.Author);
                sw.WriteLine(b.Year = book.Year);

            }
        }
    }
}

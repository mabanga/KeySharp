using System;
using System.Collections.Generic;
using System.Linq;
using LibrayIO.Models;

namespace ConsoleGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\res\intec\FileIOWithClass\ConsoleGUI\bin\Debug\Books.txt";

            List<Book> books = new List<Book>();
            books = Services.PopulateBooks();
            //Services.WriteToFile(books, path);

            //List<Book> books = new List<Book>();
            books = Services.ReadFromFile(path);
            Console.WriteLine($"Title - Author - Year");
            Console.WriteLine($"---------------------");
            List<Book> SortedBooks = books.OrderBy(book => book.Title).ToList();

            foreach (var item in SortedBooks)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

using BookLibrary.Helpers;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class BookRepository
    {
        public List<Book> Books { get; set; }

        public BookRepository()
        {
            if (!File.Exists("books.json"))
            {
                Books = new List<Book>
                {
                    new Book
                    {
                        Id=1,
                        Title="Crime And Punishment",
                        Discount=10,
                        Page=750,
                        Price=17.75,
                        BookCount=10
                    },
                    new Book
                    {
                        Id=2,
                        Title="Rich Dad Poor Dad",
                        Discount=10,
                        Page=750,
                        Price=17.75,
                        BookCount=10
                    }
                };
                FileHelper.WriteBooks(Books);
            }
            else
            {
                Books = FileHelper.ReadBooks();
            }
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            FileHelper.WriteBooks(Books);
        }
    }
}

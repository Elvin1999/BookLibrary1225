using BookLibrary.Commands;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookLibrary.ViewModels
{
    public class AddBookViewModel:BaseViewModel
    {
		private Book book;

		public Book Book
		{
			get { return book; }
			set { book = value;  OnPropertyChanged(); }
		}
		public RelayCommand AddBookCommand { get; set; }
		public AddBookViewModel()
		{
			Book = new Book();

			AddBookCommand = new RelayCommand((o) =>
			{
				Book.Id = (new Random()).Next(5, 1000000);
				App.BookRepo.AddBook(Book);
				MessageBox.Show("New Book Added successfully");
				Book = new Book();
			});

		}
	}
}

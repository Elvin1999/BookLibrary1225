using BookLibrary.Commands;
using BookLibrary.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ViewModels
{
    public class LibraryHomeUCViewModel:BaseViewModel
    {
        public RelayCommand ShowAllBooksCommand { get; set; }
        public RelayCommand AddNewBookCommand { get; set; }
        public RelayCommand RegisterStudentCommand { get; set; }
        public RelayCommand RentBookCommand { get; set; }

        public LibraryHomeUCViewModel()
        {

            RentBookCommand = new RelayCommand((o) =>
            {
                var vm=new RentUCViewModel();
                var view = new RentUC();
                view.DataContext = vm;

                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(view);
            });
            ShowAllBooksCommand = new RelayCommand((obj) =>
            {
                var view = new AllBooksUC();
                var vm = new AllBooksViewModel();
                view.DataContext = vm;

                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(view);
            });

            AddNewBookCommand = new RelayCommand((obj) =>
            {
                var view=new AddBookUC();
                var vm=new AddBookViewModel();
                view.DataContext = vm;

                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(view);
            });

            RegisterStudentCommand = new RelayCommand((o) =>
            {
                var vm=new RegisterStudentUCViewModel();
                var view = new RegisterStudentUC();

                view.DataContext = vm;

                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(view);
            });
        }
    }
}

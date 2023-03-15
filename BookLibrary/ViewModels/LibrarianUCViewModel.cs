using BookLibrary.Commands;
using BookLibrary.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookLibrary.ViewModels
{
    public class LibrarianUCViewModel:BaseViewModel
    {

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged(); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); }
        }


        public RelayCommand BackCommand { get; set; }
        public RelayCommand SignInCommand { get; set; }


        public LibrarianUCViewModel()
        {
            BackCommand = new RelayCommand((obj) =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(App.BackPage);
            });

            SignInCommand = new RelayCommand((obj) =>
            {
                if(Username=="admin" && Password == "admin")
                {
                    var vm = new LibraryHomeUCViewModel();
                    var view = new LibrantHomeUC();
                    view.DataContext = vm;

                    App.MyGrid.Children.RemoveAt(0);
                    App.MyGrid.Children.Add(view);
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            });
        }
    }
}

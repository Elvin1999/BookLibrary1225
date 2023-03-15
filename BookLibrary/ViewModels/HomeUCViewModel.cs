using BookLibrary.Commands;
using BookLibrary.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ViewModels
{
    public class HomeUCViewModel:BaseViewModel
    {
        public RelayCommand SelectLibrarianCommand { get; set; }

        public HomeUCViewModel()
        {
            SelectLibrarianCommand = new RelayCommand((obj) =>
            {
                App.BackPage = App.MyGrid.Children[0];
                App.MyGrid.Children.RemoveAt(0);

                var uc = new LibrarianUC();
                var vm=new LibrarianUCViewModel();

                uc.DataContext = vm;
                App.MyGrid.Children.Add(uc);
            });
        }
    }
}

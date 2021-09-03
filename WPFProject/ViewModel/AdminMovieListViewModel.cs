using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Command;

namespace WPFProject.ViewModel
{
    class AdminMovieListViewModel
    {
        public RelayCommand RemoveMovieBtn { get; set; }
        public RelayCommand BackBtn { get; set; }

        public AdminMovieListViewModel()
        {

            RemoveMovieBtn = new RelayCommand((e) =>
              {
                  Helper.Helper.AdminMovieListUC.AdminFilmsLstBx.Items.Remove(Helper.Helper.AdminMovieListUC.AdminFilmsLstBx.SelectedItem);
              });
            BackBtn = new RelayCommand((e) =>
              {
                  Helper.Helper.MainWindow.SecondGrid.Children.Remove(Helper.Helper.AdminMovieListUC);
              });

        }
    }
}

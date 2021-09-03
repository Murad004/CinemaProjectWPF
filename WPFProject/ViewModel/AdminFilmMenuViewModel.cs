using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Command;
using WPFProject.View;

namespace WPFProject.ViewModel
{
    public class AdminFilmMenuViewModel
    {
        public RelayCommand AddMovieBtn { get; set; }
        public RelayCommand MovieListBtn { get; set; }
        public MainWindow MainWindow = Helper.Helper.MainWindow;
        public AdminAddMovieUC adminAddMovieUC = Helper.Helper.AdminAddMovieUC;
        public AdminFilmMenuUC AdminFilmMenuUC = Helper.Helper.AdminFilmMenuUC;

        public AdminFilmMenuViewModel()
        {
            AddMovieBtn = new RelayCommand((e) =>
              {
                  Helper.Helper.MainWindow.SecondGrid.Children.Add(Helper.Helper.AdminAddMovieUC);
              });
            MovieListBtn = new RelayCommand((e) =>
              {
                  Helper.Helper.MainWindow.SecondGrid.Children.Add(Helper.Helper.AdminMovieListUC);
              });
        }

    }
}

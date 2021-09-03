using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using WPFProject.Command;
using WPFProject.View;

namespace WPFProject.ViewModel
{
    public class AdminFilmMenuViewModel
    {
        public RelayCommand AddMovieBtn { get; set; }
        public RelayCommand PhotoBtn { get; set; }
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
            PhotoBtn = new RelayCommand((e) =>
              {
                  OpenFileDialog openFileDialog = new OpenFileDialog();
                  openFileDialog.ShowDialog();
                  openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                  Helper.Helper.AdminFilmMenuUC.AdminFilmMenuImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
              });
        }

    }
}

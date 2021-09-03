using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Models;
using WPFProject.View;

namespace WPFProject.Helper
{
    public class Helper
    {
        public static MainWindow MainWindow = new MainWindow();

        public static AdminUserControl AdminUserControl = new AdminUserControl();

        public static UserUC UserUC = new UserUC();

        public static AdminFilmMenuUC AdminFilmMenuUC = new AdminFilmMenuUC();

        public static UserFilmMenuUC UserFilmMenuUC = new UserFilmMenuUC();

        public static AdminAddMovieUC AdminAddMovieUC = new AdminAddMovieUC();

        public static AdminRemoveMovieUC AdminRemoveMovieUC = new AdminRemoveMovieUC();
        public static AdminMovieListUC AdminMovieListUC = new AdminMovieListUC();
   
        public static Film Film { get; set; }

    }
}

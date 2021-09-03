using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFProject.ViewModel;

namespace WPFProject.View
{
    /// <summary>
    /// Interaction logic for AdminMovieListUC.xaml
    /// </summary>
    public partial class AdminMovieListUC : UserControl
    {
        public AdminMovieListUC()
        {
            InitializeComponent();
            DataContext = new AdminMovieListViewModel();
            Helper.Helper.AdminMovieListUC = this;
        }
    }
}

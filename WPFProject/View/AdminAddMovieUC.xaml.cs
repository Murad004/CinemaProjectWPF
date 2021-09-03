using System;
using System.Collections.Generic;
using System.Data.Linq;
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
    /// Interaction logic for AdminAddMovieUC.xaml
    /// </summary>
    public partial class AdminAddMovieUC : UserControl
    {
        public AdminAddMovieUC()
        {
            InitializeComponent();
            DataContext = new AdminAddMovieViewModel();
           
            Helper.Helper.AdminAddMovieUC = this;
        }
    }
}

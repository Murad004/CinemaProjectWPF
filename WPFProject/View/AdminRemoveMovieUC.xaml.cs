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

namespace WPFProject.View
{
    /// <summary>
    /// Interaction logic for AdminRemoveMovieUC.xaml
    /// </summary>
    public partial class AdminRemoveMovieUC : UserControl
    {
        public AdminRemoveMovieUC()
        {
            InitializeComponent();
            Helper.Helper.AdminRemoveMovieUC = this;
        }
    }
}

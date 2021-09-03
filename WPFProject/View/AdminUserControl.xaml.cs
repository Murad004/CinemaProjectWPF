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
using WPFProject.Models;
using WPFProject.Repository;
using WPFProject.ViewModel;

namespace WPFProject.View
{
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {

            DataContext = new AdminUserControlViewModel()
            {
                ucadmin = this
            };
            Helper.Helper.AdminUserControl = this;
            InitializeComponent();

        }
        
    }
}

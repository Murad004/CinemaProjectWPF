using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFProject.Command;
using WPFProject.View;

namespace WPFProject.ViewModel
{
    class UserFilmMenuViewModel
    {
        public RelayCommand BuyBtn { get; set; }
        public RelayCommand TableBtn { get; set; }
        public UserFilmMenuViewModel()
        {
            BuyBtn = new RelayCommand((e) =>
              {
                  MessageBox.Show("Buy Ticket Sucsesfully!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
              });
            TableBtn = new RelayCommand((e) =>
              {
                  TableWindow tableWindow = new TableWindow();
                  tableWindow.ShowDialog();
              });

        }
        
    }
}

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
                  if (Helper.Helper.UserFilmMenuUC.BuyBtn.IsEnabled)
                  {
                      MessageBox.Show("Buy Ticket Sucsesfully!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                  }
                  else if (Helper.Helper.UserFilmMenuUC.BuyBtn.IsEnabled == false)
                  {
                      MessageBox.Show("You have to choose a table", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                  }
              });
            TableBtn = new RelayCommand((e) =>
              {
                  Helper.Helper.UserFilmMenuUC.TableListBox.Items.Add(Helper.Helper.UserFilmMenuUC.UserFilmListBox.SelectedItem);
                  Helper.Helper.UserFilmMenuUC.BuyBtn.IsEnabled = true;
                  TableWindow tableWindow = new TableWindow();
                  tableWindow.ShowDialog();
              });

        }

    }
}

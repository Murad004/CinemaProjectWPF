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
    class TableWindowViewModel
    {
        public RelayCommand TableBtn { get; set; }
        public bool IsPressed { get; set; } = false;
        public string TableNo { get; set; }

        public TableWindow tableWindow = new TableWindow();


        public TableWindowViewModel()
        {
            TableBtn = new RelayCommand((e) =>
              {
                  IsPressed = true;
                  if (IsPressed == false)
                  {

                  }
                  else if (IsPressed == true)
                  {
                      MessageBox.Show("Table Pressed!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                  }
              });
        }
    }
}

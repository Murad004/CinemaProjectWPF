using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Command;
using WPFProject.View;

namespace WPFProject.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        public MainWindow MainWindow = Helper.Helper.MainWindow;
        public RelayCommand AdminBtn { get; set; }
        public RelayCommand UserBtn { get; set; }

        public AdminUserControl AdminUC { get; set; }
        public UserUC UserUC { get; set; }

        public RelayCommand AdminRegistrationBtn { get; set; }

        public RelayCommand UserRegistrationBtn { get; set; }

        public MainViewModel()
        {
            AdminBtn = new RelayCommand((e) =>
              {
                  AdminUC = new AdminUserControl();
                  MainWindow.SecondGrid.Children.Add(AdminUC);
              });
            AdminRegistrationBtn = new RelayCommand((e) =>
            {
               
            });
            UserBtn = new RelayCommand((e) =>
              {
                  UserUC = new UserUC();
                  MainWindow.SecondGrid.Children.Add(UserUC);
              });


        }

    }
}

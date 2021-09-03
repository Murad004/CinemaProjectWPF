using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFProject.Command;
using WPFProject.Models;
using WPFProject.Repository;
using WPFProject.View;

namespace WPFProject.ViewModel
{
    public class AdminUserControlViewModel : BaseViewModel
    {
        public MainWindow MainWindow = Helper.Helper.MainWindow;

        public FakeRepoAdmin RepoAdmin = new FakeRepoAdmin();

        public AdminUserControl ucadmin = Helper.Helper.AdminUserControl;
        public RelayCommand SignInBtn { get; set; }

        public RelayCommand SignUpBtn { get; set; }

        public AdminFilmMenuUC AdminFilmMenuUC = Helper.Helper.AdminFilmMenuUC;


        public AdminUserControlViewModel()
        {
            SignUpBtn = new RelayCommand((e) =>
              {
                  
                  RepoAdmin.Admins.Add(new Admin(
                      ucadmin.textBoxFirstName.Text,
                      ucadmin.textBoxLastName.Text,
                      int.Parse(ucadmin.textBoxAge.Text),
                      ucadmin.DatePicker.Text,
                      ucadmin.textBoxEmail.Text,
                      ucadmin.PasswordBox.Password
                      ));
                  
                  ucadmin.SignUpBtn.IsEnabled = false;
                  MessageBox.Show("Qeydiyyat ugurludur.Zehmet olmasa \"Sign in\" bolmesinde E-mail ve Parolunuzu daxil edin.", "Sucsesfully!", MessageBoxButton.OK, MessageBoxImage.Information);
              });
            SignInBtn = new RelayCommand((e) =>
              {
                  foreach (var admin in RepoAdmin.Admins)
                  {
                      if (ucadmin.UsernameTxtBoxAdmin.Text == admin.Email && ucadmin.PasswordBoxAdmin.Password == admin.Password)
                      {
                          Helper.Helper.MainWindow.SecondGrid.Children.Add(Helper.Helper.AdminFilmMenuUC);
                          Helper.Helper.AdminFilmMenuUC.AdminNameTxtBlck.Text = ucadmin.textBoxFirstName.Text;
                          Helper.Helper.AdminFilmMenuUC.AdminSurnameTxtBlck.Text = ucadmin.textBoxLastName.Text;
                          Helper.Helper.AdminFilmMenuUC.AdminAgeTxtBlck.Text = ucadmin.textBoxAge.Text;

                      }
                      else
                      {
                          MessageBox.Show("bbb","Sucsesfully!",MessageBoxButton.OK,MessageBoxImage.Information);
                      }
                  }
              });


        }
    }
}

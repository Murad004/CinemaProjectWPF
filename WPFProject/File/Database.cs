using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Models;

namespace WPFProject.File
{
    public class Database
    {
        public ObservableCollection<Admin> Admins { get; set; } = new ObservableCollection<Admin>();
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
        public ObservableCollection<Film> Films { get; set; } = new ObservableCollection<Film>();
    }
}

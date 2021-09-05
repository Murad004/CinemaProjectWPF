using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Models;

namespace WPFProject.Repository
{
    public class FakeRepoUsers
    {
        public ObservableCollection<User> Users = new ObservableCollection<User>();

        public ObservableCollection<User> GetUsers()
        {
            return Users;
        }
    }
}
